<?php

class transaction extends CI_Controller {

	public function index()
	{
		$data['view'] = 'page_not_found_view';
		$data['title'] = 'IQRA | Page Not Found';
		$data['breadcrumb_1'] = 'Page Not Found';
		$data['breadcrumb_2'] = 'Error';
		$data['breadcrumb_3'] = '404';
		$this->load->view('layout_view',$data);
	}

  public function add_new()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
      $data['view'] = 'transaction_add_new_view';
			$data['title'] = 'IQRA | Transaction';
			$data['breadcrumb_1'] = 'Transaction';
			$data['breadcrumb_2'] = 'Transaction';
			$data['breadcrumb_3'] = 'Add New';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

	public function add_new_transaction()
	{
		// Setting server side validation rules
		$this->form_validation->set_rules('type', 'Type', 'required');
		$this->form_validation->set_rules('is_of', 'Is_Of', 'required');
		$this->form_validation->set_rules('date', 'Date', 'required');
		$this->form_validation->set_rules('amount', 'Amount', 'required');
		$this->form_validation->set_rules('payment_mode', 'Payment_Mode', 'required');

		// Formatting date as per datepicker jquery plugin
		$date = explode('-',$this->input->post('date'));
		$dd = $date[0]; $mm = $date[1]; $yy = $date[2];
		// Formatting date as per mysql
		$new_date = array($date[2],$date[1],$date[0]);
		$new_date = implode('-',$new_date);

		// Saving all form values to array
		$values = array(
			'id' => '0',
			'type' => $this->input->post('type'),
			'is_of' => $this->input->post('is_of'),
			'date' => $new_date,
			'amount' => trim($this->input->post('amount'),' '),
			'payment_mode' => $this->input->post('payment_mode'),
			'cheque_number' => trim($this->input->post('cheque_number'),' '),
			'ifsc_code' => trim($this->input->post('ifsc_code'),' '),
			'comment' => trim($this->input->post('comment'),' ')
		);

		if ($this->form_validation->run() == TRUE){
			$this->load->model('transaction_model');
			if($this->transaction_model->add_transaction($values)){
				$this->input->set_cookie('message_code','1',1);
				redirect('transaction/add_new');
			}
			else {
				$this->input->set_cookie('message_code','4',1);
				redirect('transaction/add_new');
			}
		}
		else {
			$this->input->set_cookie('message_code','3',1);

			// When record is not inserted because of validation
			// following cookies will help to fill the form values
			// entered by the user after coming back from form action
			$this->input->set_cookie('type',$values['type'],1);
			$this->input->set_cookie('is_of',$values['is_of'],1);
			$this->input->set_cookie('dd',$dd,1);
			$this->input->set_cookie('mm',$mm,1);
			$this->input->set_cookie('yy',$yy,1);
			$this->input->set_cookie('amount',$values['amount'],1);
			$this->input->set_cookie('payment_mode',$values['payment_mode'],1);
			$this->input->set_cookie('cheque_number',$values['cheque_number'],1);
			$this->input->set_cookie('ifsc_code',$values['ifsc_code'],1);
			$this->input->set_cookie('comment',$values['comment'],1);

			redirect('transaction/add_new');
		}

	}

  public function show_all()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
      $data['view'] = 'transaction_show_all_view';
			$data['title'] = 'IQRA | Transaction';
			$data['breadcrumb_1'] = 'Transaction';
			$data['breadcrumb_2'] = 'Transaction';
			$data['breadcrumb_3'] = 'Show All';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

	public function show_all_transactions()
	{
		$this->load->model('transaction_model');
		$list = $this->transaction_model->get_transactions();

		// Getting transaction data and storing into cookies to display on table

		if(count($list)){
			$this->input->set_cookie('transaction_count',count($list),10);
		}
		else {
			$this->input->set_cookie('transaction_count','-1',10);
		}

		for ($i=0; $i<count($list); $i++) {
			$this->input->set_cookie('transaction_'.$i.'_0',$list[$i]['type'],10);
			$date = explode('-',$list[$i]['date']);
			$new_date = $date[2].'-'.$date[1].'-'.$date[0];
			$this->input->set_cookie('transaction_'.$i.'_2',$new_date,10);
			$this->input->set_cookie('transaction_'.$i.'_3',$list[$i]['amount'],10);
			$this->input->set_cookie('transaction_'.$i.'_5',$list[$i]['id'],10);
		}
		redirect('transaction/show_all');
	}

	public function show($id)
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			$this->load->model('transaction_model');
			$transaction = $this->transaction_model->get_transaction($id);

			// Formatting date as per datepicker jquery plugin
			$date = explode('-',$transaction[0]['date']);
			$transaction[0]['dd'] = $date[2];
			$transaction[0]['mm'] = $date[1];
			$transaction[0]['yy'] = $date[0];

			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
			$data['transaction'] = $transaction;
      $data['view'] = 'transaction_show_view';
			$data['title'] = 'IQRA | Transaction';
			$data['breadcrumb_1'] = 'Transaction';
			$data['breadcrumb_2'] = 'Transaction';
			$data['breadcrumb_3'] = 'Show';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}

	}

	public function delete_transaction($id)
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			$this->load->model('transaction_model');
			if($this->transaction_model->delete_transaction($id)){
				$this->input->set_cookie('message_code','2',1);
				redirect('transaction/show_all');
			}
			else {
				$this->input->set_cookie('message_code','4',1);
				redirect('transaction/show_all');
			}
		}
		else {
			redirect('login');
		}
	}

}

?>
