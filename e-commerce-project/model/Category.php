<?php

require_once "framework/Model.php";

class Category extends Model{
    public $title;
    public $deleted;

    public function __construct($title, $deleted) {
        $this->title = $title;
        $this->deleted = $deleted;
    }
    
    public static function add_productCategory($category_id, $product_id){
        $query = self::execute("INSERT INTO productcategory VALUES(?,?,?)",array($product_id, $category_id, false));
        return true;
    }

    public static function add_category($category){
        self::execute("INSERT INTO categories (title, deleted) VALUES(?,?)" , array($category->title, $category->deleted));
        return true;
    }
    
    public static function delete_productCategory($product_id, $category_id){
       self::execute("UPDATE productCategory set deleted = ? WHERE product_id = ? AND category_id = ?", array(true, $product_id, $category_id));
       return true;
    }
    
    public static function restore_productCategory($product_id, $category_id){
       self::execute("UPDATE productCategory set deleted = ? WHERE product_id = ? AND category_id = ?", array(false, $product_id, $category_id));
       return true;
    }
   
    
    public static function productCategory_exists($category, $product_id){
        $query = self::execute( "SELECT * FROM categories c, productcategory pc"
                . " WHERE title = ?"
                . " AND c.id = pc.category_id"
                . " AND pc.product_id = ?", array($category->title, $product_id));
        $data =  $query->fetchAll();
        return count($data) > 0;
    }
    
    public static function category_exists($category){
        $query = self::execute( "SELECT * FROM categories c"
                . " WHERE title = ?", array($category->title));
        $data =  $query->fetchAll();
        return count($data) > 0;
    }
    
    public static function get_category_count($product_id){
        $query = self::execute( "SELECT * FROM productcategory WHERE product_id = ? AND deleted = ?", array($product_id, false));
        $data =  $query->fetchAll();
        return count($data);
    }
    
    public static function getCategoriesForFilter(){
        $query = self::execute("SELECT DISTINCT title FROM categories c, productcategory pc "
                . "WHERE c.id = pc.category_id "
                . "AND pc.deleted = ?"
                . "AND c.deleted = ?", array(false, false));
        return $query->fetchAll();
    }
    
    public static function getCategories(){
        $query = self::execute("SELECT title FROM categories c WHERE deleted = ?", array(false));
        return $query->fetchAll();
    }
    
    public static function get_categoryID($category){
        $query = self::execute("SELECT * FROM categories WHERE title = ?", array($category->title));
        $data = $query->fetch();
        return $data['id'];
    }
    
    
    public static function getCategoriesForAdmin(){
        $query = self::execute("SELECT * FROM categories c ORDER BY title", array());
        return $query->fetchAll();
    }
    
    public static function modify_category($newCategory, $category_id){
        $query = self::execute("UPDATE categories SET title = ? WHERE id = ?", array($newCategory->title, $category_id));
        return true;
    }
    
    public static function delete_category($category_id){
        $query = self::execute("UPDATE categories SET deleted = ? WHERE id = ?", array(true, $category_id));
        return true;
    }
    
    public static function restore_category($category_id){
        $query = self::execute("UPDATE categories SET deleted = ? WHERE id = ?", array(false, $category_id));
        return true;
    }

}

