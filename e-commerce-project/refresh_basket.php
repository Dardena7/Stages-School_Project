<?php

    require_once '/model/Basket.php';
    require_once '/model/Good.php';

        
    if(isset($_GET['member_id']) && isset($_GET['col']) && isset($_GET['order'])){
        $member_id = $_GET['member_id'];
        $col = $_GET['col'];
        $order = $_GET['order'];
        $basket = Basket::get_basket_ordered($member_id, $col, $order);
        $res = "{\"basket\":[";
        $first = true;
        foreach ($basket as $good){
            if($first){
                $first = false;
            }
            else{
                $res .= ",";
            }
            $res .= "{\"product_id\":\"{$good['product_id']}\",\"member_id\":\"{$good['member_id']}\",\"name\":\"{$good['name']}\", \"quantity\":\"{$good['good_quantity']}\", \"price\":\"{$good['price']}\", \"total\":\"{$good['total']}\"}";
        }
        $res .= "]}";
    }
    echo $res;
?>