<?php

    require_once '/model/Product.php';
    require_once '/model/Member.php';
    require_once '/model/Category.php';
    require_once '/model/Picture.php';
    require_once '/framework/View.php';
    require_once '/framework/Controller.php';
    
    
    
    
    $products = [];
    $selectedCategory = '';

        
    if(isset($_GET['admin']) && isset($_GET['category']) && isset($_GET['min_price']) && isset($_GET['max_price']) && isset($_GET['search'])){

        $selectedCategory = $_GET['category'];
        $min_price = $_GET['min_price'];
        $max_price = $_GET['max_price'];
        $search = $_GET['search'];
        $admin = $_GET['admin'];

        if($selectedCategory == "Tout"){
            $selectedCategory = '%';
        }
        
        if($min_price == ""){
            $min_price = 0;
        }
        
        if($max_price == ""){
            $max_price = 1000000;
        }

        if($search == ""){
            $search = '%';
        }
        else{
            $search = "%$search%";
        }

        if(!$admin){
            $products = Product::get_products_filtered($selectedCategory, $min_price, $max_price, $search);
        }
        else{
            $products = Product::get_products_filtered_forAdmin($selectedCategory, $min_price, $max_price, $search);
        }
    } 
    else {
        if(!$admin){
            $products = Product::get_products();
        }
        else{
            $products = Product::get_products_forAdmin();
        }
    }
    
    $res = "{\"products\":[";
    $first = true;
    foreach ($products as $p)
    {
        if ($first)
            $first = false;
        else
            $res .= ",";
        $res .= "{\"name\":\"{$p["name"]}\", \"id\":\"{$p["id_jointure"]}\", \"deleted\":\"{$p["deleted_jointure"]}\", \"path\":\"{$p["path"]}\"}";
    }
    $res .= "]}";
    
    echo $res;
    

?>