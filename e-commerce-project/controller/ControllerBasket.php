<?php

require_once 'model/Category.php';
require_once 'model/Member.php';
require_once 'model/Basket.php';
require_once 'framework/View.php';
require_once 'framework/Controller.php';


class ControllerBasket extends Controller{
    
    public function index(){
        $member = $this->get_user_or_redirect();
        $menu = $this->get_menu();
        $member_id = Member::get_memberID($member);
        $basket = Basket::get_basket($member_id);
        
        (new View("basket"))->show(array("menu"=>$menu, "member_id"=>$member_id, "member"=>$member, "basket"=>$basket));
    }
    
    public function add_good(){
        $member = $this->get_user_or_redirect();
        $product = "";
        $quantity = "";
        
        if(isset($_POST["product_id"]) && isset($_POST["quantity"])){
            $product_id = $_POST["product_id"];
            $product = Good::get_productByID($product_id);
            $quantity = $_POST["quantity"];
            $member_id = Member::get_memberID($member);
            
            if($product->quantity >= $quantity && $quantity > 0){
                $quantityLeft = $product->quantity - $quantity;
                Product::update_quantity($product_id, $quantityLeft);
                if(Good::good_exists($member_id, $product_id)){
                    $oldQuantity = Good::get_good($member_id, $product_id)->quantity;
                    $newQuantity = $oldQuantity + $quantity;
                    Good::update_good($newQuantity, $member_id, $product_id);
                }
                else{
                    Good::add_good($member_id, $product_id, $quantity);
                }
                $this->redirect("basket");
            }
            $this->redirect("product", "productdescription/$product_id");
        }
        else{
            $this->redirect("product");
        }
    } 
    
    public function delete_good(){
        
    }
    
    public function get_menu(){
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

