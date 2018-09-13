<?php

require_once 'model/Product.php';
require_once 'model/Member.php';
require_once 'model/Category.php';
require_once 'model/Picture.php';
require_once 'model/Good.php';
require_once 'framework/View.php';
require_once 'framework/Controller.php';

class ControllerProduct extends Controller{
  
    public function index(){
        $admin = 0;
        if($this->user_logged()){
            $member = $this->get_user_or_redirect();
            $admin = $member->flag;
        }
        $menu = $this->getMenu();
        $allcategories = Category::getCategoriesForFilter();
        $prixMax = Product::getMax_Price();
        $prixMin = Product::getMin_Price();
        $this->view_products($menu, $admin, $allcategories, $prixMax, $prixMin);
    }
    
    private function view_products($menu, $admin, $allcategories, $prixMax, $prixMin){
        (new View("product"))->show(array("menu"=>$menu, "admin"=>$admin, "allcategories"=>$allcategories, "prixMax"=>$prixMax, "prixMin"=>$prixMin));
    }
    
    public function productdescription(){
        $product = '';
        $menu = $this->getMenu();
        $error = '';
        $is_logged = $this->user_logged();
        
        if(isset($_GET['id']) && $_GET['id'] != ''){
            $product_id = $_GET['id'];
            $product = Product::get_productObjectByID($product_id);
            $pictures = Product::getPictures($product_id);
            $categories = Product::getCategories($product_id);
        
            if($product){
                (new View("productdescription"))->show(array("is_logged"=>$is_logged, "menu"=>$menu, "product"=>$product, "categories"=>$categories, "pictures"=>$pictures, "product_id"=>$product_id));
            }
            else{
                $error = "Ce produit n'existe pas";
                (new View("error"))->show(array("menu"=>$menu, "error"=>$error));
            }
        }
        else{
            $error = "MISSING ID";
            (new View("error"))->show(array("menu"=>$menu, "error"=>$error));
        }
    }
    
    
    public function addProduct(){
        $member = $this->get_user_or_redirect();
        if(!$member->flag){
            $this->redirect();
        }
        else{
            $menu = $this->getMenu();
            $name = '';
            $categories = [];
            $category = '';
            $description = '';
            $price = '';
            $quantity = '';
            $picture_size = '';
            $picture_error = '';
            $picture_name = '';
            $picture_type = '';
            $errors = [];
            $success = '';
            
            $categories = Category::getCategories();
            
            if($this->addProduct_posts_are_set()){
                
                $this->stock_posts_into_variables_addProduct($name, $category, $description, $price, $quantity, $picture_size, $picture_error, $picture_name, $picture_type, $picture_tempPath);
                $errors = $this->valid_productInputs($name, $category, $description, $price, $quantity, $picture_name, $picture_error, $picture_type, $picture_size);

                if(count($errors)==0){
                    $product = new Product($name, $description, $price, $quantity, false);
                    $picture = new Picture($picture_type, false);
                    Product::add_product($product);
                    $productID = Product::getLastProductID();
                    Picture::add_picture($picture, $picture_tempPath, $productID);
                    if($category != 'Aucune'){
                        $category = new Category($category, false);
                        $categoryID = Category::get_categoryID($category);
                        Product::add_category($productID, $categoryID);
                    }
                    $success = 'Le produit a été ajouté avec succès !';
                }

            }
            (new View("addproduct"))->show(array("menu"=>$menu, "categories"=>$categories, "success"=>$success,"errors"=>$errors));
        }   
    }
    
    private function valid_productInputs($name, $category, $description, $price, $quantity, $picture_name, $picture_error, $picture_type, $picture_size)
    {
        $errors = [];
        if(strlen($name) < 1 || strlen($name) > 30){
            $errors = "Le nom du produit n'est pas valide";
        }
        if(strlen($category) < 1 || strlen($category) > 30){
            $errors = "Le nom de la catégorie n'est pas valide";
        }
        if(strlen($description) < 10 || strlen($description) > 200) {
            $errors = "La description n'est pas valide";
        }
        if(!is_numeric($price) || (int)$price <= 0){
            $errors = "Le prix n'est pas valide";
        }
        if(!is_numeric($quantity) || (int)$quantity <= 0){
            $errors = "La quantité n'est pas valide";
        }
        if($picture_error != 0) {
            $errors = "La photo contient une erreur: ".$picture_error; 
        }
        if($picture_name == '') {
            $errors = "La photo n'a pas de nom";
        }
        if($picture_type != "image/jpg" && $picture_type != "image/jpeg" && $picture_type != "image/png" && $picture_type != "image/gif") {
            $errors = "Le format de la photo n'est pas valide";
        }
        if($picture_size > 1000000){
            $errors = "Le format de la photo est supérieur à 1Mo";
        }
        return $errors;
    }
    
    private function stock_posts_into_variables_addProduct(&$name, &$category, &$description, &$price, &$quantity, &$picture_size, &$picture_error, &$picture_name, &$picture_type, &$picture_tempPath)
    {
        $name = $_POST['name']; 
        $category = $_POST['category'];
        $description = $_POST['description'];
        $price = $_POST['price'];
        $quantity = $_POST['quantity'];
        $picture_size = $_FILES['picture']['size'];
        $picture_error = $_FILES['picture']['error'];
        $picture_name = $_FILES['picture']['name'];
        $picture_type = $_FILES['picture']['type'];
        $picture_tempPath = $_FILES['picture']['tmp_name'];
    }
    
    private function addProduct_posts_are_set()
    {
        return (isset($_POST['name']) 
                && isset($_POST['description']) 
                && isset($_POST['price']) 
                && isset($_POST['quantity']) 
                && isset($_POST['category']));
    }
    
    public function delete_product()
    {
        $member = $this->get_user_or_redirect();
        $admin = $member->flag;
        if(!$admin){
            $this->redirect("product", "index");
        }
        else{
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $id = $_GET['id'];
                Product::delete_product($id);
                Good::delete_goods($id);
                $this->redirect("product", "index");
            }
        }
    }
    
    public function restore_product()
    {
        $member = $this->get_user_or_redirect();
        $admin = $member->flag;
        if(!$admin){
            $this->redirect("product", "index");
        }
        else{
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $id = $_GET['id'];
                Product::restore_product($id); 
                $this->redirect("product", "index");
            }
        }
    }
    
    public function modifyProduct($product_id = -1, $p_errors = [], $c_errors = [], $s = []){
        $menu = $this->getMenu();
        $member = $this->get_user_or_redirect();
        $admin = $member->flag;
        $product = '';
        $pictures = [];
        $allCategories = [];
        $categories = [];
        $product_errors = [];
        $picture_errors = $p_errors;
        $category_errors = $c_errors;
        $success = $s;
        
        if(((isset($_GET['id']) && $_GET['id'] != '') || $product_id != -1) && $admin){
            if($product_id == -1){
                $id = $_GET['id'];
            }
            else {
                $id = $product_id;
            }
            $allcategories = Category::getCategories();
            $product = Product::get_productObjectByID($id);
            
            
            if(isset($_POST['name']) && isset($_POST['description']) && isset($_POST['quantity']) && isset($_POST['price'])){
                $name = $_POST['name'];
                $description = $_POST['description'];
                $quantity = $_POST['quantity'];
                $price = $_POST['price'];
                
                $product_errors = $this->valid_modify_product($name, $description, $quantity, $price);
                
                if(count($product_errors) == 0){
                    $product->name = $name;
                    $product->description = $description;
                    $product->quantity = $quantity;
                    $product->price = $price;
                    Product::updateProduct($product, $id);
                    $success[] = "Modification du produit réalisée avec succès !";
                }
            }
            
            $pictures = Product::getPicturesForAdmin($id);
            $categories = Product::getCategoriesForAdmin($id);
            
            (new View("modifyproduct"))->show(array("menu"=>$menu, "id"=>$id, "product"=>$product, 
                        "pictures"=>$pictures, "allcategories"=>$allcategories, "categories"=>$categories, "product_errors"=>$product_errors,
                        "picture_errors"=>$picture_errors, "category_errors"=>$category_errors, "success"=>$success));
        }
        else{
            $this->redirect("product", "index");
        }
    }
    
    private function valid_modify_product($name, $description, $quantity, $price) {
        $errors = [];
        if(strlen($name) < 1 || strlen($name) > 30){
            $errors[] = "Le nom du produit n'est pas valide";
        }
        if(strlen($description) < 10 || strlen($description) > 200) {
            $errors[] = "La description n'est pas valide";
        }
        if(!is_numeric($price) || (int)$price <= 0){
            $errors[] = "Le prix n'est pas valide";
        }
        if(!is_numeric($quantity) || (int)$quantity < 0){
            $errors[] = "La quantité n'est pas valide";
        }
        return $errors;
    }
    
    public function add_picture(){
        $success = [];
        $picture_errors = [];
        $category_errors = [];
        $member = $this->get_user_or_redirect();
        if($member->flag){
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $product_id = $_GET['id'];
                
                if(isset($_FILES['picture']['name']) && $_FILES['picture']['name'] != ''){
                    $picture_size = $_FILES['picture']['size'];
                    $picture_error = $_FILES['picture']['error'];
                    $picture_name = $_FILES['picture']['name'];
                    $picture_type = $_FILES['picture']['type'];
                    $picture_tempPath = $_FILES['picture']['tmp_name'];
                    $picture = new Picture($picture_type, false);

                    $picture_errors = $this->valid_add_picture($picture_name, $picture_error, $picture_type, $picture_size);

                    if(count($picture_errors) == 0){
                        Picture::add_picture($picture, $picture_tempPath, $product_id);
                        array_push($success, "Photo ajoutée avec succès !");
                    }
                    $this->modifyProduct($product_id, $picture_errors, $category_errors, $success);
                }
                else{
                    $this->modifyProduct($product_id, $picture_errors, $category_errors, $success);
                }
            }
            else{
                $this->redirect();
            }
        }
        else{
            $this->redirect();
        }
    }
    
    private function valid_add_picture($picture_name, $picture_error, $picture_type, $picture_size) {
        $errors = [];
        if($picture_error != 0) {
            $errors[] = "La photo contient une erreur: ".$picture_error; 
        }
        if($picture_name == '') {
            $errors[] = "La photo n'a pas de nom";
        }
        if($picture_type != "image/jpg" && $picture_type != "image/jpeg" && $picture_type != "image/png" && $picture_type != "image/gif") {
            $errors[] = "Le format de la photo n'est pas valide";
        }
        if($picture_size > 1000000){
            $errors[] = "Le format de la photo est supérieur à 1Mo";
        }
        return $errors;
    }
    
    public function add_category(){
        $success = [];
        $picture_errors = [];
        $category_errors = [];
        $member = $this->get_user_or_redirect();
        if($member->flag){
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $product_id = $_GET['id'];
                
                if(isset($_POST['category']) && $_POST['category'] != ''){
                    $category = $_POST['category'];
                    $category = new Category($category, false);
                    $category_errors = $this->valid_add_category($category, $product_id);

                    if(count($category_errors) == 0){
                        if($category != "Aucune"){
                            $category_id = Category::get_categoryID($category);
                            Category::add_productCategory($category_id, $product_id);
                            $success[] = "Catégorie ajoutée avec succès !";
                        }
                    }
                    $this->modifyProduct($product_id, $picture_errors, $category_errors, $success);
                }
                else{
                    $this->modifyProduct($product_id, $picture_errors, $category_errors, $success);
                }
            }
            else{
                $this->redirect();
            }
        }
        else{
            $this->redirect();
        }
    }
    
    private function valid_add_category($category, $product_id) {
        $errors = [];
        if(strlen($category->title) < 1 || strlen($category->title) > 30){
            $errors[] = "Le nom de la catégorie n'est pas valide";
        }
        if(Category::productCategory_exists($category, $product_id)){
            $errors[] = "Le produit possède déjà cette catégorie";
        }
        return $errors;
    }
    
    public function deletePicture(){
        $user = $this->get_user_or_redirect();
        $admin = $user->flag;
        $picture_errors = [];
        $category_errors = [];
        $success = [];
        
        if($admin){
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $picture_id = $_GET['id'];
                $product_id = Picture::get_productID($picture_id);
                $count = Picture::getPicturesCount($product_id);
                
                if($count > 1){
                    Picture::delete_picture($picture_id);
                    array_push($success, "Photo retirée avec succès");
                }
                else{
                    array_push($picture_errors, "Il faut au moins une photo");
                }
                
                $this->modifyProduct($product_id, $picture_errors, $category_errors, $success);
            }
            else{
                $this->redirect();
            }
        }
        else{
            $this->redirect();
        }  
    }
    
    public function restorePicture(){
        $user = $this->get_user_or_redirect();
        $admin = $user->flag;
        $picture_errors = [];
        $category_errors = [];
        $success = [];
        
        if($admin){
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $picture_id = $_GET['id'];
                $product_id = Picture::get_productID($picture_id);
                Picture::restore_picture($picture_id);
                array_push($success, "Photo restaurée avec succès");
                
                $this->modifyProduct($product_id, $picture_errors, $category_errors, $success);
            }
            else{
                $this->redirect();
            }
        }
        else{
            $this->redirect();
        }  
    }
    
    public function deleteCategory(){
        $user = $this->get_user_or_redirect();
        $admin = $user->flag;
        $menu = $this->getMenu();
        $category_errors = [];
        $picture_errors = [];
        $success = [];
        
        if($admin){
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $ids = $_GET['id'];
                $ids = $ids = explode('_', $ids);
                $id_product = $ids[0];
                $id_category = $ids[1];
                $count = Category::get_category_count($id_product);
                
                Category::delete_productCategory($id_product, $id_category);
                array_push($success, "Catégorie retirée avec succès");
                
                $this->modifyProduct($id_product, $picture_errors, $category_errors, $success);
            }
            else{
                $this->redirect("index", "modifyproduct");
            }
        }
        else{
            $this->redirect("index", "product");
        }  
    }
    
    public function restoreCategory(){
        $user = $this->get_user_or_redirect();
        $admin = $user->flag;
        $menu = $this->getMenu();
        $category_errors = [];
        $picture_errors = [];
        $success = [];
        
        if($admin){
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $ids = $_GET['id'];
                $ids = $ids = explode('_', $ids);
                $id_product = $ids[0];
                $id_category = $ids[1];
                
                Category::restore_productCategory($id_product, $id_category);
                array_push($success, "Catégorie restaurée avec succès");
                
                $this->modifyProduct($id_product, $picture_errors, $category_errors, $success);
            }
            else{
                $this->redirect("index", "modifyproduct");
            }
        }
        else{
            $this->redirect("index", "product");
        }  
    }


    public function getMenu(){
        if($this->user_logged()){
            $user = $this->get_user_or_redirect();
            $menu = '';      
            if($user->flag){
                $menu = "menu_admin.html";
            }
            else{
                $menu = "menu_user.html";
            }
            return $menu;
        }
        else{
            return "menu_base.html";
        }
    }

}