<?php

require_once "framework/Model.php";

class Product extends Model{
    public $name;
    public $description;
    public $price;
    public $quantity;
    public $deleted;

    public function __construct($name, $description, $price, $quantity, $deleted){
        $this->name = $name;
        $this->description = $description;
        $this->price = $price;
        $this->quantity = $quantity;
        $this->deleted = $deleted;
    }
    
    public static function update_quantity($product_id, $newQuantity){
        self::execute("UPDATE products SET quantity = ? WHERE id = ?", array($newQuantity, $product_id));
        return true;
    }
    
    
    public static function add_category($productID, $categoryID){
        $query = self::execute("SELECT * FROM productcategory where product_id = ? AND category_id = ?",array($productID, $categoryID));
        $data = $query->fetch(); // un seul résultat au maximum
        if($query->rowCount()==0){
            self::execute("INSERT INTO productcategory (product_id, category_id, deleted) VALUES(?,?,?)" , array($productID, $categoryID, false));
        }
        return true;
    }
    
    public static function getLastProductID(){
        $query = self::execute("SELECT id FROM products ORDER BY id DESC LIMIT 1", array());
        $data = $query->fetch();
        return $data['id'];
    }
    
    public static function get_productObjectByID($id){
        $query = self::execute("SELECT * FROM products WHERE id = ?", array($id));
        $data = $query->fetch();
        return new Product($data['name'], $data['description'], $data['price'], $data['quantity'], $data['deleted']);
    }

    public static function add_product($product){
        self::execute("INSERT INTO products (name, description, price, quantity, deleted) VALUES(?,?,?,?,?)" , 
                array($product->name,$product->description,$product->price,
                    $product->quantity, false));
        return true;
    }
    
    public static function updateProduct($product, $id){
        self::execute("UPDATE products SET name = ?, description = ?, quantity = ?, price = ? WHERE id = ?", 
                array($product->name, $product->description, $product->quantity, $product->price,$id));
        return true;
    }
    
    public static function restore_product($product_id){
        self::execute("UPDATE products SET deleted = ? WHERE id = ?", array(false, $product_id));
        return true;
    }
    
    public static function delete_product($product_id){
        self::execute("UPDATE products SET deleted = ? WHERE id = ?", array(true, $product_id));
        return true;
    }
    
    public static function get_product($name){
        $query = self::execute("SELECT * "
                . "FROM products pr, pictures pi, categories c, productPicture pp, productCategory pc "
                . "WHERE pr.id = pp.product_id "
                . "AND pi.id = pp.picture_id "
                . "AND pr.id = pc.product_id "
                . "AND c.id = pc.category_id "
                . "AND pr.deleted = ? "
                . "AND pr.name = ? "
                . "GROUP BY pr.id",
                array(false, $name));
        return $query->fetch(); 
    }
    
    public static function get_productByID($id){
        $query = self::execute("SELECT * "
                . "FROM products pr, pictures pi, categories c, productCategory pc "
                . "WHERE pr.id = pc.product_id "
                . "AND c.id = pc.category_id "
                . "AND pr.id = ? "
                . "AND pr.deleted = ? "
                . "GROUP BY pr.id",
                array($id, false));
        return $query->fetch();
    }
    
    public static function get_products(){
        $query = self::execute("SELECT *, pr.id id_jointure, pr.deleted deleted_jointure "
                . "FROM products pr, pictures pi, categories c, productCategory pc "
                . "WHERE pr.id = pi.product_id "
                . "AND pr.id = pc.product_id "
                . "AND c.id = pc.category_id "
                . "AND pr.quantity > ? "
                . "AND pr.deleted = ? "
                . "GROUP BY pr.id",
                array(0, false));
        return $query->fetchAll();
    }
    
    public static function get_products_forAdmin(){
        $query = self::execute("SELECT *, pr.id id_jointure, pr.deleted deleted_jointure "
                . "FROM products pr, pictures pi, categories c, productCategory pc "
                . "WHERE pr.id = pi.product_id "
                . "AND pr.id = pc.product_id "
                . "AND c.id = pc.category_id "
                . "GROUP BY pr.id ",
                array());
        return $query->fetchAll();
    }
    
   public static function get_products_filtered($category, $min_price, $max_price, $search){
       $request = "";
       $array = [];
       if($category == '%'){
            $request .= "SELECT *, pr.id id_jointure, pr.deleted deleted_jointure "
                 . "FROM products pr, pictures pi "
                 . "WHERE pr.id = pi.product_id "
                 . "AND pr.price >= ? "
                 . "AND pr.price <= ? "
                 . "AND (pr.description LIKE ? OR pr.name LIKE ?)"
                 . "AND pr.quantity > ? "
                 . "AND pr.deleted = ? "
                 . "AND pi.deleted = ? "
                 . "GROUP BY pr.id";
            $array = [$min_price, $max_price, $search, $search, 0, false, false];
       }
       else{
           $request .= "SELECT *, pr.id id_jointure, pr.deleted deleted_jointure "
                . "FROM products pr, pictures pi, categories c, productCategory pc "
                . "WHERE pr.id = pi.product_id "
                . "AND pr.id = pc.product_id "
                . "AND c.id = pc.category_id "
                . "AND c.title LIKE ? "
                . "AND pr.price >= ? "
                . "AND pr.price <= ? "
                . "AND (pr.description LIKE ? OR pr.name LIKE ?)"
                . "AND pr.quantity > ? "
                . "AND pr.deleted = ? "
                . "AND pc.deleted = ? "
                . "AND pi.deleted = ? "
                . "GROUP BY pr.id";
           $array = [$category, $min_price, $max_price, $search, $search, 0, false, false, false];
       }
        $query = self::execute($request, $array);
        return $query->fetchAll();
    }

    public static function get_products_filtered_forAdmin($category, $min_price, $max_price, $search){
        $request = "";
        $array = [];
        if($category == '%'){
            $request = "SELECT *, pr.id id_jointure, pr.deleted deleted_jointure "
                    . "FROM products pr, pictures pi "
                    . "WHERE pr.id = pi.product_id "
                    . "AND pr.price >= ? "
                    . "AND pr.price <= ? "
                    . "AND (pr.description LIKE ? OR pr.name LIKE ?)" 
                    . "AND pi.deleted = ? "
                    . "GROUP BY pr.id";
            $array = [$min_price, $max_price, $search, $search, false];
        }
        else{
            $request = "SELECT *, pr.id id_jointure, pr.deleted deleted_jointure "
                    . "FROM products pr, pictures pi, categories c, productCategory pc "
                    . "WHERE pr.id = pi.product_id "
                    . "AND pr.id = pc.product_id "
                    . "AND c.id = pc.category_id "
                    . "AND c.title LIKE ? "
                    . "AND pr.price >= ? "
                    . "AND pr.price <= ? "
                    . "AND (pr.description LIKE ? OR pr.name LIKE ?)" 
                    . "AND pc.deleted = ? "
                    . "AND pi.deleted = ? "
                    . "GROUP BY pr.id";
            $array = [$category, $min_price, $max_price, $search, $search, false, false];
        }
        $query = self::execute($request, $array);
        return $query->fetchAll();
    }
    
    public static function getPricesForMinPrice(){
         $query = self::execute("SELECT price FROM products ORDER BY price", array());
         return $query->fetchAll();
    }
    
    public static function getPricesForMaxPrice(){
         $query = self::execute("SELECT price FROM products ORDER BY price DESC", array());
         return $query->fetchAll();
    }
    
    public static function getPictures($product_id){
        $query = self::execute( "SELECT * FROM pictures WHERE product_id = ? AND deleted = ?", array($product_id, false));
        return $query->fetchAll();
    }
    
    public static function getPicturesForAdmin($product_id){
        $query = self::execute( "SELECT * FROM pictures WHERE product_id = ?", array($product_id));
        return $query->fetchAll(); 
    }
    
    public static function getCategories($product_id){
        $query = self::execute( "SELECT * FROM productcategory pc, categories c"
                . " WHERE pc.category_id = c.id"
                . " AND product_id = ?"
                . " AND pc.deleted = ?"
                . " AND c.deleted = ?", array($product_id, false, false));
        return $query->fetchAll();
    }
    
    public static function getCategoriesForAdmin($product_id){
        $query = self::execute( "SELECT *, pc.deleted pc_deleted FROM productcategory pc, categories c"
                . " WHERE pc.category_id = c.id"
                . " AND product_id = ?"
                . " AND c.deleted = ?", array($product_id, false));
        return $query->fetchAll();
    }
    
    public static function getCategoriesCount($product){
        $query = self::execute( "SELECT * "
                . "FROM categories c, products pr, productCategory pc "
                . "WHERE c.id = pc.category_id "
                . "AND pr.id = pc.product_id "
                . "AND pr.name = ?",
                array($product->name));
        $data = $query->fetchAll();
        return count($data);
    }
    
    public static function getMin_Price(){
        $query = self::execute("select min(price) as min_price from products ", array());
        $data = $query->fetch();
        return $data['min_price'];
    }
    
     public static function getMax_Price(){
        $query = self::execute("select max(price) as max_price from products ", array());
        $data = $query->fetch();
        return $data['max_price'];
    }
}