<?php
require_once 'model/Member.php';
require_once 'framework/View.php';
require_once 'framework/Controller.php';


class ControllerLogin extends Controller{
    
    
    public function index(){
        $menu = $this->get_menu();
        (new View("index"))->show(array("menu"=>$menu));
    }
    
    
    //  Insciption
    //--------------------------------------------------------------------------
    
    public function inscription(){
        
        $menu = $this->get_menu();
        $pseudo = '';
        $password = '';
        $password_confirm = '';
        $lastname = '';
        $firstname = '';
        $email = '';
        $phone = '';
        $NN = ' ';
        $birthday = '';
        $errors = [];
        
        if($this->inscription_posts_are_set())
        {
            $this->stock_inscription_posts_into_variables($pseudo, $password, $password_confirm, $lastname, $firstname, $birthday, $email, $phone, $NN);
            $errors = $this->valid_signup($pseudo,$password, $password_confirm, $NN);
            if(count($errors)==0){
                $this->add_and_connect_new_member($pseudo, $password, $lastname, $firstname, $birthday, $email, $phone, $NN);
            }
        }
        
        $this->inscription_view($menu, $pseudo, $password, $password_confirm, $lastname, $firstname, $birthday, $email, $phone, $NN, $errors);
    }
    
    private function inscription_view($menu, $pseudo, $password, $password_confirm, $lastname, $firstname, $birthday, $email, $phone, $NN, $errors){
        (new View("inscription"))->show(array("menu"=>$menu, 
                                                "pseudo"=>$pseudo,
                                                "password"=>$password, 
                                                "password_confirm"=>$password_confirm, 
                                                "lastname"=>$lastname, 
                                                "firstname"=>$firstname, 
                                                "birthday"=>$birthday,                                
                                                "email"=>$email, 
                                                "phone"=>$phone, 
                                                "NN"=>$NN,
                                                "errors"=>$errors)
                                            );
    }
    
    private function inscription_posts_are_set(){
        return (isset($_POST['pseudo']) 
                && isset($_POST['password']) 
                && isset($_POST['password_confirm']) 
                && isset($_POST['lastname']) 
                && isset($_POST['firstname']) 
                && isset($_POST['birthday'])
                && isset($_POST['email']) 
                && isset($_POST['phone'])
                && isset($_POST['NN']));
    }
    
    private function stock_inscription_posts_into_variables(&$pseudo, &$password, &$password_confirm, &$lastname, &$firstname, &$birthday, &$email, &$phone, &$NN){
        $pseudo = trim($_POST['pseudo']);
        $password = $_POST['password'];
        $password_confirm = $_POST['password_confirm'];
        $lastname = $_POST['lastname'];
        $firstname = $_POST['firstname'];
        $birthday = $_POST['birthday'];
        $email = $_POST['email'];
        $phone = $_POST['phone'];
        $NN = $_POST['NN'];
    }

    private function valid_signup($pseudo, $password,$password_confirm, $NN){
        $errors = [];
        if(Member::member_exists($pseudo)){
            $errors[] = "This user already exists.";
        } if($pseudo == ''){
            $errors[] = "Pseudo is required.";
        } if(strlen($pseudo) < 3 || strlen($pseudo) > 16) {
            $errors[] = "Pseudo length must be between 3 and 16.";
        } if(!preg_match("/^[a-zA-Z][a-zA-Z0-9]*$/",$pseudo)) {
            $errors[] = "Pseudo must start by a letter and must contain only letters and numbers.";
        } if(strlen($password) < 8 || strlen($password) > 16) {
            $errors[] = "Password length must be between 3 and 16.";
        } if(!((preg_match("/[A-Z]/",$password)) && preg_match("/\d/",$password) && preg_match("/['\";:,.\/?\\-]/",$password))){
            $errors[] = "Password must contain one uppercase letter, one number and one punctuation mark.";
        } if($password != $password_confirm) {
            $errors[] = "You have to enter twice the same password.";
        }
        if(strlen($NN) > 11 || strlen($NN)<11){
            $errors[] = "Numéro National is required and must contains 11 characters.";
        }
        return $errors;
    }  
    
    private function add_and_connect_new_member($pseudo,$password,$lastname, $firstname, $birthday, $email, $phone, $NN){
        $member = new Member($pseudo,$this->my_hash($password),$lastname, $firstname, $birthday, $email, $phone, $NN, false, false);
        Member::add_member($member);
        $this->log_user($member);
    }
    
    //--------------------------------------------------------------------------
    
    
    
    
   // Connexion
   //--------------------------------------------------------------------------
    
   public function login(){
       
        $menu = $this->get_menu();
        $pseudo = '';
        $password = '';
        $errors = [];
        
        if ($this->login_posts_are_set()) {
            $pseudo = $_POST['pseudo'];
            $password = $_POST['password'];
            $member = Member::get_member($pseudo);
            $errors = $this->valid_login($member, $pseudo, $password);
            if(count($errors) == 0){
                $this->log_user($member);
            }
        }
        $this->login_view($menu, $pseudo, $password, $errors);
    }
    
    private function login_view($menu, $pseudo, $password, $errors){
        (new View("login"))->show(array("menu"=>$menu, 
                                        "pseudo"=>$pseudo,
                                        "password"=>$password,
                                        "errors"=>$errors)
                                    );
    }
    
    private function login_posts_are_set(){
        return isset($_POST['pseudo']) && isset($_POST['password']);
    }
    
    private function valid_login($member, $pseudo, $password){
        $errors = [];
        if(!$member){
            array_push($errors, "Can't find a member with the pseudo '$pseudo'. Please sign up.");
        }
        else{
            if($member->deleted){
                array_push($errors, "This member has been deleted, please contact the admin for more informations");
            }
            else{
                if(!$this->check_password($password, $member->password)){
                        array_push($errors, "Wrong password. Please try again.");
                }
            }
        }
        return $errors;
    }
    
    //--------------------------------------------------------------------------
    
    
    
    
    //Menu
    //--------------------------------------------------------------------------
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
    //--------------------------------------------------------------------------

}