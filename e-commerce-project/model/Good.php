<?php
require_once "framework/Model.php";
require_once "model/Product.php";

class Good extends Model{
    public $member_id;
    public $product_id;
    public $product;
    public $product_name;
    public $quantity;
    public $total;

    public function __construct($member_id, $product_id, $qty){
        $this->member_id = $member_id;
        $this->product_id = $product_id;
        $this->product = self::get_productByID($product_id);
        $this->quantity = $qty;
        $this->total = $this->get_total($product_id, $qty);
    }
    
    public static function update_good($newQuantity, $member_id, $product_id){
        self::execute("UPDATE goods SET quantity = ? WHERE member_id = ? AND product_id = ?", array($newQuantity, $member_id, $product_id));
        return true;
    }
    
    public static function get_total($product_id, $quantity){
        $total = 0;
        $price = self::get_productByID($product_id)->price;
        $total += $price * $quantity;
        return $total;
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
        $data = $query->fetch();
        if($query->rowCount() < 1){
            return false;
        }
        else{
            return new Product($data["name"], $data["description"], $data["price"], $data["quantity"], $data["deleted"]);
        }
    }
    
    
    public static function get_good($member_id, $product_id){
        $query = self::execute("SELECT * FROM goods WHERE member_id = ? AND product_id = ?", array($member_id, $product_id));
        $data = $query->fetch();
        if($query->rowCount() < 1){
            return false;
        }
        else{
            return new Good($data['member_id'], $data['product_id'], $data['quantity']);
        }
    }
    
    public static function good_exists($member_id, $product_id){
        $query = self::execute("SELECT * FROM goods WHERE member_id = ? AND product_id = ?", array($member_id, $product_id));
        return $query->rowCount() > 0;
    }
    
    public static function add_good($member_id, $product_id, $quantity){
        $query = self::execute("INSERT INTO goods(member_id, product_id, quantity) VALUES(?, ?, ?)", array($member_id, $product_id, $quantity));
        return true;
    }
    
    public static function delete_goods($product_id){
        self::execute("DELETE FROM goods WHERE product_id =?", array($product_id));
        return true;
    }
}