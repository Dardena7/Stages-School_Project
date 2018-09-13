<?php
require_once "framework/Model.php";
require_once "model/Good.php";

class Basket extends Model{
    public $member_id;
    public $good_list = [];
    public $total;

    public function __construct($member_id){
        $this->member_id = $member_id;
        $this->good_list = self::get_goodList($member_id);
        $this->total = self::get_total(self::get_goodList($member_id));
    }
    
    public static function get_basket($member_id){
        return new Basket($member_id);
    }
    
    public static function get_basket_ordered($member_id, $col, $order){
        $query = self::execute("SELECT *, goods.quantity good_quantity, goods.quantity*price total "
                                . "FROM goods, products "
                                . "WHERE member_id = ? "
                                . "AND goods.product_id = products.id "
                                . "ORDER BY $col $order", array($member_id));
        return $query->fetchAll();
    }
    
    public static function get_goodList($member_id){
        $list = [];
        $query = self::execute("SELECT * FROM goods WHERE member_id = ?", array($member_id));
        $data = $query->fetchAll();
        foreach($data as $d){
            $good = new Good($d["member_id"], $d["product_id"], $d["quantity"]);
            array_push($list, $good);
        }
        return $list;
    }
    
    public static function get_total($good_list){
        $total = 0;
        foreach ($good_list as $good){
            $total += $good->total;
        }
        return $total;
    }
    
    public static function add_good($good){
        if($this->good_exists($good)){
            $oldQty = Good::get_good($good->member_id, $good->product_id)->quantity;
            $newQty = $oldQty + $good->quantity;
            $query = self::execute("UPDATE goods SET quantity = ? WHERE member_id = ? AND product_id = ?", array($newQty, $this->member_id, $good->product_id));
        }
        else{
            $query = self::execute("INSERT INTO goods VALUE(?, ? , ?)", array($this->member_id, $good->product_id, $good->quantity));
        }
        
        return true;
    }
    
    public static function delete_good($member_id, $product_id){
        $query = self::execute("SELECT * FROM goods WHERE member_id = ? AND product_id = ?", array($member_id, $product_id));
        $data = $query->fetch();
        $good_quantity = $data["quantity"];
        $query = self::execute("SELECT * FROM products WHERE id = ?", array($product_id));
        $data = $query->fetch();
        $product_quantity = $data["quantity"];
        $product_quantity += $good_quantity;
        self::execute("UPDATE products SET quantity = ? WHERE id = ?", array($product_quantity, $product_id));
        self::execute("DELETE FROM goods WHERE member_id = ? AND product_id =?", array($member_id, $product_id));
        return true;
    }
    
    public static function delete_basket($member_id){
        self::execute("DELETE FROM goods WHERE member_id = ?", array($member_id));
        return true;
    }
    
}