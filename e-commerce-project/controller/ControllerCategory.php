<?php

require_once 'model/Category.php';
require_once 'model/Member.php';
require_once 'framework/View.php';
require_once 'framework/Controller.php';


class ControllerCategory extends Controller{

    public function index($s = "", $e = ""){
        $success = $s;
        $error = $e;
        $member = $this->get_user_or_redirect();
        $admin = $member->flag;
        $menu = "menu_admin.html";
        if($admin){
            $categories = Category::getCategoriesForAdmin();
            (new View("categories"))->show(array("menu"=>$menu, "categories"=>$categories, "success"=>$success, "error"=>$error));
        }
        else{
            $this->redirect();
        }
    }
    
    public function addCategory(){
        $newCategory = "";
        $error = "";
        $success = "";
        $member = $this->get_user_or_redirect();
        $admin = $member->flag;
        if($admin){
            if(isset($_POST["newCategory"]) && $_POST["newCategory"] != ""){
                $newCategory = $_POST["newCategory"];
                $category = new Category($newCategory, false);
                $error = $this->valid_add_category($category);
                if($error === ""){
                    Category::add_category($category);
                    $success = "La catégorie a bien été ajoutée";
                }
            }
            $this->index($success, $error);
        }
        else{
            $this->redirect();
        }
    }
    
    public function modify_category() {
        $newCategory = "";
        $error = "";
        $success = "";
        $category_id = "";
        $member = $this->get_user_or_redirect();
        $admin = $member->flag;
        if($admin){
            if(isset($_POST["newCategory"]) && isset($_POST['category_id'])){
                $category_id = $_POST['category_id'];
                $newCategory = $_POST["newCategory"];
                $newCategory = new Category($newCategory, false);
                $error = $this->valid_add_category($newCategory);
                if($error === ""){
                    Category::modify_category($newCategory, $category_id);
                    $success = "La catégorie a bien été modifiée";
                }
            }
            $this->index($success, $error);
        }
        else{
            $this->redirect();
        }
    }
    
    private function valid_add_category($category) {
        $error = "";
        if(strlen($category->title) < 1 || strlen($category->title) > 30){
            $error = "Le nom de la catégorie n'est pas valide";
        }
        if(Category::category_exists($category)){
            $error = "Le produit possède déjà cette catégorie";
        }
        return $error;
    }
    
    public function delete_category(){
        $success = "";
        $error = "";
        $category_id = "";
        $member = $this->get_user_or_redirect();
        $admin = $member->flag;
        if($admin){
            if(isset($_GET['id']) && $_GET['id'] != ""){
                $category_id = $_GET['id'];
                Category::delete_category($category_id);
                $success = "La catégorie a bien été supprimée";
            }
            $this->index($success, $error);
        }
        else{
            $this->redirect();
        }
    }
    
    public function restore_category(){
        $success = "";
        $error = "";
        $category_id = "";
        $member = $this->get_user_or_redirect();
        $admin = $member->flag;
        if($admin){
            if(isset($_GET['id']) && $_GET['id'] != ""){
                $category_id = $_GET['id'];
                Category::restore_category($category_id);
                $success = "La catégorie a bien été restaurée";
            }
            $this->index($success, $error);
        }
        else{
            $this->redirect();
        }
    }
}

