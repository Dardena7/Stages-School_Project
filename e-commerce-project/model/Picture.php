<?php

require_once "framework/Model.php";

class Picture extends Model{
   public $path;
   public $deleted;
   public $repertory = "pictures/";
   
   public function __construct($type, $deleted) {
        $path = $this->setPath($type);
        $this->path = $path;
        $this->deleted = $deleted;
   }
   
   public static function delete_picture($id){
       $query = self::execute( "UPDATE pictures SET deleted = ? WHERE id = ?", array(true, $id));
   }
   
   public static function restore_picture($id){
       $query = self::execute( "UPDATE pictures SET deleted = ? WHERE id = ?", array(false, $id));
   }
   
   public static function getPicturesCount($product_id){
        $query = self::execute( "SELECT * FROM pictures WHERE product_id = ? AND deleted = ?", array($product_id, false));
        $data =  $query->fetchAll();
        return count($data);
    }
   
   public static function get_productId($picture_id){
        $query = self::execute("SELECT product_id FROM pictures where id = ?",array($picture_id));
        $data = $query->fetch();
        return $data['product_id'];
    }
   
   private function setPath($type){
       $path = '';
        if($type=="image/gif"){
            $path = $this->repertory."photo".time().".gif";
        }
        else if($type=="image/jpg"){
            $path = $this->repertory."photo".time().".jpg";
        }
        else if($type=="image/jpeg"){
            $path = $this->repertory."photo".time().".jpg";
        }
        else if($type=="image/png"){
            $path = $this->repertory."photo".time().".png";
        }
        return $path;
   }
   
   public static function add_picture($picture, $tempPath, $productID){
       self::execute("INSERT INTO pictures (product_id, path, deleted) VALUES(?,?,?)" , array($productID, $picture->path, $picture->deleted));
       move_uploaded_file($tempPath, "$picture->path");
       return true;
   }
   
   public static function getPath($picture){
       return $picture->path;
   }
   
   private function add_pictureToRepertory($picture, $temp_path){
       move_uploaded_file($temp_path, $picture->path);
       return true;
   }
}
