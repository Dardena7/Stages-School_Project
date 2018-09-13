<?php
require_once '/model/Basket.php';

        
    if(isset($_GET['member_id'])){
        $member_id = $_GET['member_id'];
        $basket = Basket::get_basket($member_id);
        foreach($basket->good_list as $good){
            Basket::delete_good($member_id, $good->product_id);
        }
        echo "ok";
    }
?>

