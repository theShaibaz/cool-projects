<?php

class fees_model extends CI_Model {

  public function add_student_entry($values){
    $this->load->database();

    // Adding student entry in fees tables
    $this->db->insert('tbl_fees_term_one',array(
                      'id' => '0',
                      'gr_number' => $values['gr_number'],
                      'class' => $values['class'],
                      'division' =>$values['division']));
    $this->db->insert('tbl_fees_term_two',array(
                      'id' => '0',
                      'gr_number' => $values['gr_number'],
                      'class' => $values['class'],
                      'division' =>$values['division']));

  }

  public function delete_student_entry($grnumber){
    $this->load->database();

    // Adding student entry in fees tables
    $this->db->delete('tbl_fees_term_one',array('gr_number' => $grnumber));
    $this->db->delete('tbl_fees_term_two',array('gr_number' => $grnumber));

  }

  public function get_fees_term_one($grnumber,$class,$division){
    $this->load->database();

    $query = $this->db->select('*')->get_where('tbl_fees_term_one',
                                               array('gr_number' => $grnumber,
                                                     'class' => $class,
                                                     'division' => $division));
    return $query->result_array();
  }

  public function get_fees_term_two($grnumber,$class,$division){
    $this->load->database();

    $query = $this->db->select('*')->get_where('tbl_fees_term_two',
                                               array('gr_number' => $grnumber,
                                                     'class' => $class,
                                                     'division' => $division));
    return $query->result_array();
  }

  public function get_all_term_one($class,$division){
    $this->load->database();

    $query = $this->db->select('*')->get_where('tbl_fees_term_one',
                                               array('class' => $class,
                                                     'division' => $division,
                                                     'passed_out' => '0'));
    return $query->result_array();
  }

  public function get_all_term_two($class,$division){
    $this->load->database();

    $query = $this->db->select('*')->get_where('tbl_fees_term_two',
                                               array('class' => $class,
                                                     'division' => $division,
                                                     'passed_out' => '0'));
    return $query->result_array();
  }

  public function update_fees_term_one($grnumber,$class,$division,$term_one_values){
    $this->load->database();

    $query = $this->db->where(array('gr_number' => $grnumber,
                                    'class' => $class,
                                    'division' => $division))
                      ->update('tbl_fees_term_one',$term_one_values);

    return 1;
  }

  public function change_class_term_one($grnumber){
    $this->load->database();

    $query = $this->db->where(array('gr_number' => $grnumber))
                      ->update('tbl_fees_term_one',array('passed_out' => '1'));

    return 1;
  }

  public function change_class_term_two($grnumber){
    $this->load->database();

    $query = $this->db->where(array('gr_number' => $grnumber))
                      ->update('tbl_fees_term_two',array('passed_out' => '1'));

    return 1;
  }

  public function update_fees_term_two($grnumber,$class,$division,$term_two_values){
    $this->load->database();

    $query = $this->db->where(array('gr_number' => $grnumber,
                                    'class' => $class,
                                    'division' => $division))
                      ->update('tbl_fees_term_two',$term_two_values);

    return 1;
  }

}

?>
