<?php

class dashboard extends CI_Controller {

	public function index()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			// Gathering income/expense stats from transaction table (today & month)
			$income_day = 0;
			$expense_day = 0;
			$income_month = 0;
			$expense_month = 0;
			$day = date('Y-m-d');
			$month = date('Y-m');

			$this->load->model('transaction_model');

			$list = $this->transaction_model->get_transaction_by_day($day);
			for ($i=0; $i<count($list); $i++) {
				if($list[$i]['type']=='Income'){
					$income_day = $income_day + $list[$i]['amount'];
				}
				elseif($list[$i]['type']=='Expense'){
					$expense_day = $expense_day + $list[$i]['amount'];
				}
			}

			$list = $this->transaction_model->get_transaction_by_month($month);
			for ($i=0; $i<count($list); $i++) {
				if($list[$i]['type']=='Income'){
					$income_month = $income_month + $list[$i]['amount'];
				}
				elseif($list[$i]['type']=='Expense'){
					$expense_month = $expense_month + $list[$i]['amount'];
				}
			}

			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
			$data['view'] = 'dashboard_view';
			$data['title'] = 'IQRA | Dashboard';
			$data['breadcrumb_1'] = 'Dashboard';
			$data['breadcrumb_2'] = 'Home';
			$data['breadcrumb_3'] = 'Dashboard';
			$data['income_day'] = $income_day;
			$data['income_month'] = $income_month;
			$data['expense_day'] = $expense_day;
			$data['expense_month'] = $expense_month;
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

}

?>
