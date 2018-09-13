<?php

require_once 'View.php';

class Tools{
    //nettoie le string donné
    public static function sanitize($var)
    {
        $var = stripslashes($var);
        $var = strip_tags($var);
        $var = htmlentities($var);
        return $var;
    }
    
    //dirige vers la page d'erreur
    public static function abort($err)
    {
        (new View("error"))->show(array("error"=>$err));
        die;
    }

}
