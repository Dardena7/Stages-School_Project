<?php

require_once "framework/Model.php";

class Member extends Model{
   public $pseudo;
   public $password;
   public $lastname;
   public $firstname;
   public $birthday;
   public $email;
   public $phone;
   public $NN;
   public $flag;
   public $deleted;

   public function __construct($pseudo, $password, $lastname, $firstname, $birthday,
                                $email, $phone, $NN, $flag, $deleted){
        $this->pseudo = $pseudo;
        $this->password = $password;
        $this->lastname = $lastname;
        $this->firstname = $firstname;
        $this->email = $email;
        $this->phone = $phone;
        $this->NN = $NN;
        $this->birthday = $birthday;
        $this->flag = $flag;
        $this->deleted = $deleted;
    }
    
    public static function get_memberID($member){
        $query = self::execute("SELECT * FROM members WHERE pseudo = ?", array($member->pseudo));
        $data = $query->fetch();
        return $data["id"];
    }
    
     public static function add_member($member){
        self::execute("INSERT INTO members (pseudo, password, lastname, firstname, birthday, email, phone, NN, flag, deleted) VALUES(?,?,?,?,?,?,?,?,?)" , 
                array($member->pseudo,$member->password,$member->lastname,
                    $member->firstname, $member->birthday, $member->email,
                    $member->phone, $member->NN, $member->flag,$member->deleted));
        return true;
    }
    
    public static function update_member($member){
        self::execute("UPDATE Members SET lastname=?, firstname=?, birthday=?, email=?, phone=?, NN=?, member=?, password=? WHERE pseudo=? ",
                array($member->lastname,$member->firstname, $member->birthday, $member->email, $member->phone, $member->NN, $member->password, $member->pseudo));
        return true;
    }
    
    public static function delete_member($member){
        self::execute("UPDATE members SET deleted=? WHERE pseudo=?;",array(true, $member->pseudo));
        return true;
    }
    
    public static function restore_member($member){
        self::execute("UPDATE members SET deleted=? WHERE pseudo=?;",array(false, $member->pseudo));
        return true;
    }
    
    public static function unset_admin($member){
        self::execute("UPDATE members SET flag=? WHERE pseudo=?;",array(false, $member->pseudo));
        return true;
    }
    
    public static function set_admin($member){
        self::execute("UPDATE members SET flag=? WHERE pseudo=?;",array(true, $member->pseudo));
        return true;
    }
    
    public static function get_member($pseudo){
        $query = self::execute("SELECT * FROM members where pseudo = ?",array($pseudo));
        $data = $query->fetch(); // un seul résultat au maximum
        if($query->rowCount()==0){
            return false;
        }
        else{
            return new Member($data["pseudo"], $data["password"], $data['lastname'], 
                                $data['firstname'], $data['birthday'], $data['email'], 
                                $data['phone'], $NN['NN'], $data['flag'], $data['deleted']);
        }
    }
    
    public static function get_member_list($member)
    {
        $query = self::execute("SELECT * FROM Members WHERE pseudo != ?", array($member->pseudo));
        $result = $query->fetchAll();
        $members = [];
        foreach($result as $r){
            array_push($members, new Member($r['pseudo'],
                                            $r['password'],
                                            $r['lastname'],
                                            $r['firstname'],
                                            $r['birthday'],
                                            $r['email'],
                                            $r['phone'],
                                            $r['NN'],
                                            $r['flag'],
                                            $r['deleted']));
        }
        return $members;
    }
    
    public static function member_exists($pseudo){
        $query = self::execute("SELECT pseudo FROM Members WHERE pseudo = ?", array($pseudo));
        return $query->rowCount() == 1;
    }
    
}