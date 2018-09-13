<?php

require_once 'model/Member.php';
require_once 'framework/View.php';
require_once 'framework/Controller.php';

class ControllerMember extends Controller{
    public function index(){
        $this->redirect();
    }
    
    //profil de l'utilisateur connecté 
    //-------------------------------------------------------------------------
    public function profile(){
        $member = $this->get_user_or_redirect();
        $menu = $this->getMenu();
        $password = "";
        $password_confirm = "";
        $lastname = "";
        $firstname = "";
        $birthday = "";
        $email = "";
        $phone = "";
        $NN = "";
        $errors = [];
        $success = [];
        
        if($this->profile_posts_are_set()){
            $this->stock_posts_into_variables($password, $password_confirm, $lastname, $firstname, $NN);
            $errors = $this->valid_edit($password, $password_confirm, $lastname, $firstname);
            if(count($errors) == 0){
                $success = $this->edit_profile($member, $password, $lastname, $firstname, $birthday, $email, $phone, $NN);
            }
        }
        $this->profile_view($menu, $member, $errors, $success);
    }
    
    private function profile_view($menu, $member, $errors, $success){
        (new View("profile"))->show(array("menu"=>$menu, 
                                            "member"=>$member, 
                                            "errors"=>$errors, 
                                            "success"=>$success));
    }
    
    private function edit_profile($member, $password, $lastname, $firstname, $birthday, $email, $phone, $NN){
        $success = [];
        if($password != ""){
            $member->password = $password;
            array_push($success, "Password has been modified.");
        }
        if($member->lastname != $lastname){
            $member->lastname = $lastname;
            array_push($success, "Lastname has been modified.");
        }
        if($member->firstname != $firstname){
            $member->firstname = $firstname;
            array_push($success, "Firstname has been modified.");
        }
        if($member->birthday != $birthday){
            $member->birthday = $birthday;
            array_push($success, "Birthday has been modified.");
        }
        if($member->email != $email){
            $member->email = $email;
            array_push($success, "Email has been modified.");
        }
        if($member->phone != $phone){
            $member->phone = $phone;
            array_push($success, "Phone has been modified.");
        }
        
        if($memeber>NN != $NN){
            $member->NN = $NN;
            array_push($success, "Numéro National has been modified.");
        }
        Member::update_member($member);
        return $success;
    }
    
    private function valid_edit($password, $password_confirm, $lastname, $firstname){
        $errors = [];
        if($password != ""){
            $errors = $this->valid_password($password, $password_confirm);
        }
        if(strlen($lastname) < 3 || strlen($lastname) > 24) {
            $errors[] = "Lastname length must be between 3 and 24.";
        } 
        if(!preg_match("/^[a-zA-Z]*$/",$lastname)) {
        $errors[] = "Lastname must start by a letter and must contain only letters and numbers.";
        }
        if(strlen($firstname) < 3 || strlen($firstname) > 24) {
            $errors[] = "Firstname length must be between 3 and 24.";
        } 
        if(!preg_match("/^[a-zA-Z]*$/",$firstname)) {
            $errors[] = "Firstname must start by a letter and must contain only letters and numbers.";
        }
        
        return $errors;
    }
    
    private function valid_password($password, $password_confirm)
    {
        $errors = [];
        if(strlen($password) < 8 || strlen($password) > 16) {
            $errors[] = "Password length must be between 3 and 16.";
        } if(!((preg_match("/[A-Z]/",$password)) && preg_match("/\d/",$password) && preg_match("/['\";:,.\/?\\-]/",$password))){
            $errors[] = "Password must contain one uppercase letter, one number and one punctuation mark.";
        } if($password != $password_confirm) {
            $errors[] = "You have to enter twice the same password.";
        } 
        return $errors;
    }
    
    private function stock_posts_into_variables(&$password, &$password_confirm, &$lastname, &$firstname, &$birthday, &$email, &$phone, &$NN){
        $password = $_POST['password'];
        $password_confirm = $_POST['password_confirm'];
        $lastname = $_POST['lastname'];
        $firstname = $_POST['firstname'];
        $birthday = $_POST['birthday'];
        $email = $_POST['email'];
        $phone = $_POST['phone'];
        $NN = $_POST['NN'];
    }
    
    private function profile_posts_are_set(){
        return (isset($_POST['password']) 
                && isset($_POST['password_confirm']) 
                && isset($_POST['lastname']) 
                && isset($_POST['firstname']) 
                && isset($_POST['birthday'])
                && isset($_POST['email']) 
                && isset($_POST['phone'])
                && isset($_POST['NN']));
    }
    
    //-------------------------------------------------------------------------
    
    
    
    //Liste des membres
    //-------------------------------------------------------------------------
    public function delete_member()
    {
        $member = $this->get_user_or_redirect();
        if(!$member->flag){
            $this->redirect();
        }
        else{
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $member_pseudo = $_GET['id'];
                $member = Member::get_member($member_pseudo);
                if($member){
                    Member::delete_member($member);
                }          
            }
        $this->memberList();
        }
    }
    
    public function restore_member()
    {
        $member = $this->get_user_or_redirect();
        if(!$member->flag){
            $this->redirect();
        }
        else{
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $member_pseudo = $_GET['id'];
                $member = Member::get_member($member_pseudo);
                if($member){
                    Member::restore_member($member);
                }          
            }
        $this->memberList();
        }
    }
    
    public function set_admin()
    {
        $member = $this->get_user_or_redirect();
        if(!$member->flag){
            $this->redirect();
        }
        else{
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $member_pseudo = $_GET['id'];
                $member = Member::get_member($member_pseudo);
                if($member){
                    Member::set_admin($member);
                }          
            }
        $this->memberList();
        }
    }
    
    public function unset_admin()
    {
        $member = $this->get_user_or_redirect();
        if(!$member->flag){
            $this->redirect();
        }
        else{
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $member_pseudo = $_GET['id'];
                $member = Member::get_member($member_pseudo);
                if($member){
                    Member::unset_admin($member);
                }          
            }
        $this->memberList();
        }
    }

    public function memberList()
    {
        $member = $this->get_user_or_redirect();
        if(!$member->flag){
            $this->redirect();
        }
        else{
            $menu = $this->getMenu();
            $members = Member::get_member_list($member);
            $this->view_memberList($menu, $member, $members);
        }
    }
    
    private function view_memberList($menu, $member, $members){
        (new View("members"))->show(array("menu"=>$menu, "member"=>$member,"members"=>$members));
    }
    
    //-------------------------------------------------------------------------
    
    
    //Modifier membre
    //-------------------------------------------------------------------------
    public function modify_member(){
        $menu = $this->getMenu();
        $admin = $this->get_user_or_redirect();

        $password = "";
        $password_confirm = "";
        $lastname = "";
        $firstname = "";
        $birthday = "";
        $email = "";
        $phone = "";
        $NN = "";
        $errors = [];
        $success = [];
        if(!$admin->flag){
            $this->redirect();
        }
        else{
            if(isset($_GET['id']) && $_GET['id'] != ''){
                $member_pseudo = $_GET['id'];
                $member = Member::get_member($member_pseudo);
                if($member){
                    if($this->profile_posts_are_set()){
                        $this->stock_posts_into_variables($password, $password_confirm, $lastname, $firstname, $birthday, $email, $phone, $NN);
                        $errors = $this->valid_edit($password, $password_confirm, $lastname, $firstname);
                        if(count($errors) == 0){
                            $success = $this->edit_profile($member, $password, $lastname, $firstname, $birthday, $email, $phone, $NN);
                        }
                    }
                    $this->view_modify_member($menu, $admin, $member, $errors, $success);
                }
                else{
                    $this->memberList();
                }
            }
        }
    }
    
    private function view_modify_member($menu, $admin, $member, $errors, $success){
        (new View("modify_member"))->show(array("menu"=>$menu, 
                                            "member"=>$member, 
                                            "errors"=>$errors, 
                                            "success"=>$success));
    }
    
    //-------------------------------------------------------------------------
    
    public function getMenu(){
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

