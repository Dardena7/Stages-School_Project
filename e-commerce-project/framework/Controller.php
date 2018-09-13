<?php

require_once 'Configuration.php';

abstract class Controller{

    public function __construct(){
        session_start();
    }
    
    //connecte l'utilisateur donné et redirige vers la page d'acceuil
    protected function log_user($member){
        $_SESSION["user"] = $member;
        $this->redirect();
        //see http://codingexplained.com/coding/php/solving-concurrent-request-blocking-in-php
        session_write_close(); 
    }
    
    //déconnecte l'utilisateur et redirige vers l'accueil
    public function logout(){
        $_SESSION = array();
        session_destroy();
        $this->redirect();
    }
    
    
    //redirige le navigateur vers l'action demandée
    public function redirect($controller = "", $action = "index", $id = "", $statusCode = 303)
    {
        $web_root = Configuration::get("web_root");
        $default_controller  = Configuration::get("default_controller");
        if ($controller == "") {
            $controller = $default_controller;
        }

        header('Location: '.$web_root.$controller."/".$action."/".$id, true, $statusCode);
        die();
    }

    //indique un l'utilisateur est connecté
    public function user_logged(){
        if (!isset($_SESSION['user'])) {
            return false;
        } else {
            return true;
        }
    }

    //renvoie l'utilisateur connecté ou redige vers l'accueil
    public function get_user_or_redirect()
    {
        if (!$this->user_logged()) {
            $this->redirect();
        } else {
            $user = $_SESSION['user'];
        }
        
        return $user;
    }

    //renvoie le string donné haché.
    public function my_hash($password)
    {
        $prefix_salt = "vJemLnU3";
        $suffix_salt = "QUaLtRs7";
        return md5($prefix_salt.$password.$suffix_salt);        
    }

    //indique si un mot de passe correspond à son hash
    public function check_password($password, $hash)
    {
        return $hash === $this->my_hash($password);  
    }

    //tout controleur doit posséder une méthode index, c'est son action
    //par défaut
    public abstract function index();


}