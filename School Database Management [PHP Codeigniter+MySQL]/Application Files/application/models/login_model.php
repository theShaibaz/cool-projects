<?php

class login_model extends CI_Model {

  public function get_user($username,$password){
    $this->load->database();

    // Getting user from database
    $query = $this->db->select('password')->get_where('tbl_login',array('username' => $username));
    // Checking if something is returned by the query or not
    if($query->result_array()){
      // Verifying given password with password from database **password hash**
      $hash = element('password',$query->result_array()[0]);
      return password_verify($password,$hash);
    }
  }

  public function change_password($username,$password){
    $this->load->database();

    // Changing user password
    return $query = $this->db->where(array('username' => $username))
                             ->update('tbl_login',array('password' => $password));
  }

}

?>
