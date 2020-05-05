<?php

class login extends CI_Controller {

	public function index()
	{
		// echo password_hash('',PASSWORD_DEFAULT);
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			redirect('dashboard');
		}
		else {
			$this->load->view('login_view');
		}
	}

  public function authenticate()
	{
		$this->form_validation->set_rules('username', 'Username', 'required');
		$this->form_validation->set_rules('password', 'Password', 'required');

		if ($this->form_validation->run() == TRUE){
			$username = $this->input->post('username');
			$password = $this->input->post('password');

	    $this->load->model('login_model');
			// Checking if entered user present in database or not
	    if ($this->login_model->get_user($username,$password)){
				// Starting new session for active user **session already started at config file**
				$this->session->set_userdata('isactive','1');
				if($username=='user'){
					$this->session->set_userdata('username','user');
				}
				elseif ($username=='admin') {
					$this->session->set_userdata('username','admin');
				}
				elseif ($username=='sudo') {
					$this->session->set_userdata('username','sudo');
				}
				redirect('dashboard');
	    }
			else {
				// Displaying error message and redirecting to login page
				$this->input->set_cookie('message_code','4',1);
				redirect('login');
			}
		}
		else {
			$this->input->set_cookie('message_code','3',1);
			redirect('login');
		}

	}

	public function change_password()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
			$data['view'] = 'change_password_view';
			$data['title'] = 'IQRA | Change Password';
			$data['breadcrumb_1'] = 'Change Password';
			$data['breadcrumb_2'] = 'Home';
			$data['breadcrumb_3'] = 'Change Password';
			$this->load->view('layout_view',$data);
		}
		else {
			$this->load->view('login_view');
		}
	}

	public function update_password()
	{
			$username = $this->input->post('user');
			$password = $this->input->post('password');
			if($password){
				$new_password = password_hash($password,PASSWORD_DEFAULT);

				$this->load->model('login_model');
				if($this->login_model->change_password($username,$new_password)){
					$this->input->set_cookie('message_code','2',1);
					redirect('login/change_password');
				}
				else {
					$this->input->set_cookie('message_code','4',1);
					redirect('login/change_password');
				}
			}
			else {
				$this->input->set_cookie('message_code','3',1);
				redirect('login/change_password');
			}
	}

	public function logout()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			$this->session->unset_userdata('isactive');
			redirect('login');
		}
		else {
			$this->load->view('login_view');
		}
	}

}

?>
