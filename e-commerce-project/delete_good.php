<?php

    require_once '/model/Basket.php';

        
    if(isset($_GET['member_id']) && isset($_GET['product_id'])){
        $member_id = $_GET['member_id'];
        $product_id = $_GET['product_id'];
        $result = Basket::delete_good($member_id, $product_id);
        if($result){
            echo "L'article a bien été supprimé du panier";
        }
        else{
            echo "La suppression de l'article a échoué";
        }
    }
?>