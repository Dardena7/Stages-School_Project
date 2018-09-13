<?php
require_once '/model/Good.php';

if(isset($_GET['member_id']) && isset($_GET['product_id']) && isset($_GET['newQuantity'])){
    $member_id = $_GET['member_id'];
    $product_id = $_GET['product_id'];
    $newQuantity = $_GET['newQuantity'];
    
    $good_oldQuantity = Good::get_good($member_id, $product_id)->quantity;
    $diffQuantity = $newQuantity - $good_oldQuantity;
    $product_oldQuantity = Good::get_productByID($product_id)->quantity;
    if($product_oldQuantity >= $diffQuantity && $newQuantity > 0){
        $product_newQuantity = $product_oldQuantity - $diffQuantity;
        Good::update_good($newQuantity, $member_id, $product_id);
        Product::update_quantity($product_id, $product_newQuantity);
        
        echo "La modification a bien été effectuée";
    }
    else{
        echo "La quantité désirée n'est pas disponible";
    }
}
