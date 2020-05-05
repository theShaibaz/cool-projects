  <?php

class transaction_model extends CI_Model {

  // Will add a transaction entry
  public function add_transaction($transaction_values){
    $this->load->database();

    return $query = $this->db->insert('tbl_transactions',$transaction_values);
  }

  // Will fetch a transaction
  public function get_transaction($id){
    $this->load->database();

    $query = $this->db->select('*')
                      ->get_where('tbl_transactions',array('id' => $id));
    return $query->result_array();
  }

  // Will fetch all transactions
  public function get_transactions(){
    $this->load->database();

    $query = $this->db->select('type,is_of,date,amount,payment_mode,id')
                      ->get('tbl_transactions');
    return $query->result_array();
  }

  // Will fetch transactions by date e.g. '2001-01-01'
  public function get_transaction_by_day($date){
    $this->load->database();

    $query = $this->db->select('type,is_of,amount')
                      ->get_where('tbl_transactions',array('date' => $date));
    return $query->result_array();
  }

  // Will fetch transactions by month e.g. '2001-01'
  public function get_transaction_by_month($date){
    $this->load->database();

    $query = $this->db->select('date,type,is_of,amount')
                      ->get_where('tbl_transactions',array('left(date,7)' => $date));
    return $query->result_array();
  }

  // Will fetch distinct dates
  public function get_distinct_dates($date){
    $this->load->database();

    $query = $this->db->select('distinct(date)')->order_by('date')
                      ->get_where('tbl_transactions',array('left(date,7)' => $date));
    return $query->result_array();
  }

  // Will update a transaction
  public function update_transaction($values){
    $this->load->database();

    return $query = $this->db->where(array('id' => $values['id']))
                      ->update('tbl_transactions',$values);
  }

  // Will delete a transaction
  public function delete_transaction($id){
    $this->load->database();

    return $query = $this->db->delete('tbl_transactions',array('id' => $id));
  }

}

?>
