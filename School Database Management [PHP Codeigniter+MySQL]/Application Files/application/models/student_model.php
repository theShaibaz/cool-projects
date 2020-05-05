<?php

class student_model extends CI_Model {

  // Will add a student
  public function add_student($values){
    $this->load->database();

    // Following queries will check for entered gr number, name, aadhar already
    // present in the database or not
    $query = $this->db->select('name')->get_where('tbl_students',array('gr_number' => $values['gr_number']));
    $count_1 = count($query->result_array());
    $query = $this->db->select('gr_number')->get_where('tbl_students',array('name' => $values['name']));
    $count_2 = count($query->result_array());
    $query = $this->db->select('gr_number')->get_where('tbl_students',array('aadhar' => $values['aadhar']));
    $count_3 = count($query->result_array());

    // Respectinve error codes
    if($count_1){
      return 11;
    }
    elseif ($count_2) {
      return 12;
    }
    elseif ($count_3 && $values['aadhar']) {
      return 13;
    }
    else{
      // Adding student record in student as well as in fees tables
      $query = $this->db->insert('tbl_students',$values);
      // $this->load->model('fees_model');
      // $this->fees_model->add_student_entry($values);

      // Returning record inserted
      return $query;
    }

  }

  // Will fetch name of a student which is not passed out yet
  public function get_student($grnumber){
    $this->load->database();

    // Following queries will check for entered gr number, name, aadhar already
    // present in the database or not
    $query = $this->db->select('name')
                      ->get_where('tbl_students',
                        array('gr_number' => $grnumber,'passed_out' => '0'));
    return $query->result_array();

  }

  // Will fetch name of a student which is passed out
  public function get_every_student($grnumber){
    $this->load->database();

    // Following queries will check for entered gr number, name, aadhar already
    // present in the database or not
    $query = $this->db->select('name')
                      ->get_where('tbl_students',
                        array('gr_number' => $grnumber));
    return $query->result_array();

  }

  // Will fetch a student info which is not passed out yet
  public function get_student_full($grnumber){
    $this->load->database();

    // Following queries will check for entered gr number, name, aadhar already
    // present in the database or not
    $query = $this->db->select('*')
                      ->get_where('tbl_students',
                        array('gr_number' => $grnumber,'passed_out' => '0'));
    return $query->result_array();

  }

  // Will fetch a student info which is passed out
  public function get_every_student_full($grnumber){
    $this->load->database();

    // Following queries will check for entered gr number, name, aadhar already
    // present in the database or not
    $query = $this->db->select('*')
                      ->get_where('tbl_students',
                        array('gr_number' => $grnumber));
    return $query->result_array();

  }

  // Will fetch all students class div wise
  public function get_students($class,$division){
    $this->load->database();

    // Following queries will check for entered gr number, name, aadhar already
    // present in the database or not
    $query = $this->db->select('gr_number,name')
                      ->get_where('tbl_students',
                        array('class' => $class, 'division' => $division,'passed_out' => '0'));
    return $query->result_array();

  }

  // Will update student info
  public function update_student($values){
    $this->load->database();

    $query = $this->db->select('gr_number')->get_where('tbl_students',array('aadhar' => $values['aadhar']));
    $count_3 = count($query->result_array());

    if($count_3 && $values['aadhar']){
      return 13;
    }
    else {
      return $query = $this->db->where(array('gr_number' => $values['gr_number']))
                        ->update('tbl_students',$values);
    }

  }

  // Will update student class
  public function update_student_class($grnumber,$class,$division){
    $this->load->database();

    return $query = $this->db->where(array('gr_number' => $grnumber))
                             ->update('tbl_students',array('class' => $class,'division' => $division));

  }

  // Will update student passed out status 0->1
  public function update_student_passed_out($grnumber){
    $this->load->database();

    return $query = $this->db->where(array('gr_number' => $grnumber))
                             ->update('tbl_students',array('passed_out' => '1'));

  }

  // Will delete a student
  public function delete_student($grnumber){
    $this->load->database();

    $this->db->delete('tbl_fees_term_one',array('gr_number' => $grnumber));
    $this->db->delete('tbl_fees_term_two',array('gr_number' => $grnumber));
    $this->db->delete('tbl_invoices',array('gr_number' => $grnumber));

    return $query = $this->db->delete('tbl_students',array('gr_number' => $grnumber));
  }

}

?>
