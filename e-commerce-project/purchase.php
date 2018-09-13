<?php

require_once '/model/Basket.php';

if(isset($_GET['member_id'])){
    $member_id = $_GET['member_id'];
    if(Basket::delete_basket($member_id)){
        echo "L'achat a bien été effectué";
    }
    else{
        echo "Il y a eu une erreur lors de l'achat";
    }
}

?>

