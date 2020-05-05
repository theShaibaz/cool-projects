<?php

class invoice_model extends CI_Model {

  // Will add a invoice entry
  public function add_invoice($invoice_values){
    $this->load->database();

    return $this->db->insert('tbl_invoices',$invoice_values);
  }

  // Will fetch a invoice
  public function get_invoice($id){
    $this->load->database();

    $query = $this->db->select('*')
                      ->get_where('tbl_invoices',array('id' => $id));
    return $query->result_array();
  }

  // Will fetch invoives filtered by date e.g.'2001-01-01'
  public function get_invoice_by_day($date){
    $this->load->database();

    $query = $this->db->select('particulars,amount')
                      ->get_where('tbl_invoices',array('date' => $date));
    return $query->result_array();
  }

  // Will fetch invoives filtered by month e.g.'2001-01'
  public function get_invoice_by_month($date){
    $this->load->database();

    $query = $this->db->select('date,particulars,amount')
                      ->get_where('tbl_invoices',array('left(date,7)' => $date));
    return $query->result_array();
  }

  // Will fetch distinct dates from given month
  public function get_distinct_dates($date){
    $this->load->database();

    $query = $this->db->select('distinct(date)')->order_by('date')
                      ->get_where('tbl_invoices',array('left(date,7)' => $date));
    return $query->result_array();
  }

  // Will fetch id of recently added invoice i.e. last invoice
  public function get_invoice_id(){
    $this->load->database();

    $query = $this->db->limit(1)->select('id')->order_by('id','DESC')
                      ->get('tbl_invoices');
    return $query->result_array();
  }

  // Will fetch all invoices
  public function get_invoices(){
    $this->load->database();

    $query = $this->db->select('gr_number,class,division,date,grand_total,id')
                      ->get('tbl_invoices');
    return $query->result_array();
  }

  // Will delete a invoice
  public function delete_invoice($id){
    $this->load->database();

    return $query = $this->db->delete('tbl_invoices',array('id' => $id));
  }

}

?>
