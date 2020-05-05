<?php

class student extends CI_Controller {

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
      $data['view'] = 'student_add_new_view';
			$data['title'] = 'IQRA | Student';
			$data['breadcrumb_1'] = 'Student';
			$data['breadcrumb_2'] = 'Student';
			$data['breadcrumb_3'] = 'Add New';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

	public function add_new_student()
	{
		$this->form_validation->set_rules('grnumber', 'GRNumber', 'required');
		$this->form_validation->set_rules('fullname', 'Fullname', 'required');
		$this->form_validation->set_rules('class', 'Class', 'required');
		$this->form_validation->set_rules('division', 'Division', 'required');
		$this->form_validation->set_rules('contact', 'Contact', 'required');
		$this->form_validation->set_rules('address', 'Address', 'required');

		// Saving all form values to array
		$values = array(
			'gr_number' => trim($this->input->post('grnumber'),' '),
			'name' => trim($this->input->post('fullname'),' '),
			'class' => $this->input->post('class'),
			'division' => $this->input->post('division'),
			'aadhar' => trim($this->input->post('aadhar'),' '),
			'contact' => trim($this->input->post('contact'),' '),
			'alt_contact' => trim($this->input->post('altcontact'),' '),
			'email' => trim($this->input->post('email'),' '),
			'address' => trim($this->input->post('address'),' '),
			'landmark' => trim($this->input->post('landmark'),' '),
			'comment' => trim($this->input->post('comment'),' ')
		);

		if ($this->form_validation->run() == TRUE){
	    $this->load->model('student_model');

			// Passing array with all form values to model
			// and getting resepective return value
			$return_val = $this->student_model->add_student($values);
	    if ($return_val==1){
				// Rerurn value will be 1 only when record is inserted
				// Showing success message
				$this->input->set_cookie('message_code','1',1);
				redirect('student/add_new');
	    }
			else {
				// Showing error message
				$this->input->set_cookie('message_code','3',1);
				if($return_val==11){
					$this->input->set_cookie('message','Entered gr number already present',1);
				}
				elseif ($return_val==12) {
					$this->input->set_cookie('message','Entered student name already present',1);
				}
				elseif ($return_val==13) {
					$this->input->set_cookie('message','Entered aadhar number already present',1);
				}
				else {
					$this->input->set_cookie('message_code','4',1);
					redirect('student/add_new');
				}
				// When record is not inserted because of above reasons
				// following cookies will help to fill the form values
				// entered by the user after coming back from form action
				$this->input->set_cookie('grnumber',$values['gr_number'],1);
				$this->input->set_cookie('fullname',$values['name'],1);
				$this->input->set_cookie('class',$values['class'],1);
				$this->input->set_cookie('division',$values['division'],1);
				$this->input->set_cookie('aadhar',$values['aadhar'],1);
				$this->input->set_cookie('contact',$values['contact'],1);
				$this->input->set_cookie('altcontact',$values['alt_contact'],1);
				$this->input->set_cookie('email',$values['email'],1);
				$this->input->set_cookie('address',$values['address'],1);
				$this->input->set_cookie('landmark',$values['landmark'],1);
				$this->input->set_cookie('comment',$values['comment'],1);

				redirect('student/add_new');
			}
		}
		else {
			$this->input->set_cookie('message_code','3',1);
			$this->input->set_cookie('message','* Marked fields are mendatory',1);

			// When record is not inserted because of above reasons
			// following cookies will help to fill the form values
			// entered by the user after coming back from form action
			$this->input->set_cookie('grnumber',$values['gr_number'],1);
			$this->input->set_cookie('fullname',$values['name'],1);
			$this->input->set_cookie('class',$values['class'],1);
			$this->input->set_cookie('division',$values['division'],1);
			$this->input->set_cookie('aadhar',$values['aadhar'],1);
			$this->input->set_cookie('contact',$values['contact'],1);
			$this->input->set_cookie('altcontact',$values['alt_contact'],1);
			$this->input->set_cookie('email',$values['email'],1);
			$this->input->set_cookie('address',$values['address'],1);
			$this->input->set_cookie('landmark',$values['landmark'],1);
			$this->input->set_cookie('comment',$values['comment'],1);

			redirect('student/add_new');
		}
	}

  public function show_all()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
      $data['view'] = 'student_show_all_view';
			$data['title'] = 'IQRA | Student';
			$data['breadcrumb_1'] = 'Student';
			$data['breadcrumb_2'] = 'Student';
			$data['breadcrumb_3'] = 'Show All';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

	public function show_all_students($class='',$division='')
	{
		if(!$class && !$division){
			$class = $this->input->post('class');
			$division = $this->input->post('division');
		}

		// Fetching students based on class and devision
		$this->load->model('student_model');
		$list = $this->student_model->get_students($class,$division);

		// Storing student data into cookies to be displayed on table
		$this->input->set_cookie('student_count',count($list),10);
		for ($i=0; $i<count($list); $i++) {
			$this->input->set_cookie('student_'.$i.'_0',$list[$i]['gr_number'],10);
			$this->input->set_cookie('student_'.$i.'_1',$list[$i]['name'],10);
			$this->input->set_cookie('student_'.$i.'_2',$class,10);
			$this->input->set_cookie('student_'.$i.'_3',$division,10);
		}
		redirect('student/show_all');
	}

	public function edit($grnumber)
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			$this->load->model('student_model');
			$student = $this->student_model->get_student_full($grnumber);

			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
			$data['student'] = $student;
      $data['view'] = 'student_edit_view';
			$data['title'] = 'IQRA | Student';
			$data['breadcrumb_1'] = 'Student';
			$data['breadcrumb_2'] = 'Student';
			$data['breadcrumb_3'] = 'Edit';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}

	}

	public function update_student()
	{
		// Setting server side validation rules
		$this->form_validation->set_rules('contact', 'Contact', 'required');
		$this->form_validation->set_rules('address', 'Address', 'required');

		// Saving all form values to array
		$values = array(
			'gr_number' => trim($this->input->post('grnumber'),' '),
			'name' => trim($this->input->post('fullname'),' '),
			'class' => $this->input->post('class'),
			'division' => $this->input->post('division'),
			'aadhar' => trim($this->input->post('aadhar'),' '),
			'contact' => trim($this->input->post('contact'),' '),
			'alt_contact' => trim($this->input->post('altcontact'),' '),
			'email' => trim($this->input->post('email'),' '),
			'address' => trim($this->input->post('address'),' '),
			'landmark' => trim($this->input->post('landmark'),' '),
			'comment' => trim($this->input->post('comment'),' ')
		);

		if ($this->form_validation->run() == TRUE){
			$this->load->model('student_model');
			$return_val = $this->student_model->update_student($values);

			if($return_val==1){
				$this->input->set_cookie('message_code','1',1);
				redirect('student/edit/'.$this->input->post('grnumber'));
			}
			elseif ($return_val==13) {
				$this->input->set_cookie('message_code','3',1);
				$this->input->set_cookie('message','Entered aadhar number already present',1);

				// When record is not inserted because of above reasons
				// following cookies will help to fill the form values
				// entered by the user after coming back from form action
				$this->input->set_cookie('grnumber',$values['gr_number'],1);
				$this->input->set_cookie('fullname',$values['name'],1);
				$this->input->set_cookie('class',$values['class'],1);
				$this->input->set_cookie('division',$values['division'],1);
				$this->input->set_cookie('aadhar',$values['aadhar'],1);
				$this->input->set_cookie('contact',$values['contact'],1);
				$this->input->set_cookie('altcontact',$values['alt_contact'],1);
				$this->input->set_cookie('email',$values['email'],1);
				$this->input->set_cookie('address',$values['address'],1);
				$this->input->set_cookie('landmark',$values['landmark'],1);
				$this->input->set_cookie('comment',$values['comment'],1);

				redirect('student/edit/'.$this->input->post('grnumber'));
			}
			else {
				$this->input->set_cookie('message_code','4',1);
				redirect('student/edit/'.$this->input->post('grnumber'));
			}
		}
		else {
			$this->input->set_cookie('message_code','3',1);
			$this->input->set_cookie('message','* Marked fields are mendatory',1);

			// When record is not inserted because of above reasons
			// following cookies will help to fill the form values
			// entered by the user after coming back from form action
			$this->input->set_cookie('grnumber',$values['gr_number'],1);
			$this->input->set_cookie('fullname',$values['name'],1);
			$this->input->set_cookie('class',$values['class'],1);
			$this->input->set_cookie('division',$values['division'],1);
			$this->input->set_cookie('aadhar',$values['aadhar'],1);
			$this->input->set_cookie('contact',$values['contact'],1);
			$this->input->set_cookie('altcontact',$values['alt_contact'],1);
			$this->input->set_cookie('email',$values['email'],1);
			$this->input->set_cookie('address',$values['address'],1);
			$this->input->set_cookie('landmark',$values['landmark'],1);
			$this->input->set_cookie('comment',$values['comment'],1);

			redirect('student/edit/'.$this->input->post('grnumber'));
		}

	}

	public function show($grnumber)
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			$this->load->model('student_model');
			$student = $this->student_model->get_student_full($grnumber);

			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
			$data['student'] = $student;
      $data['view'] = 'student_show_view';
			$data['title'] = 'IQRA | Student';
			$data['breadcrumb_1'] = 'Student';
			$data['breadcrumb_2'] = 'Student';
			$data['breadcrumb_3'] = 'Show';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}

	}

	public function delete_student($grnumber)
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			$this->load->model('student_model');
			$student = $this->student_model->get_student_full($grnumber);
			// Checking student deleted or not
			if($this->student_model->delete_student($grnumber)){
				// Removing student entry from fees tables
				$this->load->model('fees_model');
				$this->fees_model->delete_student_entry($grnumber);

				$this->input->set_cookie('message_code','2',1);
				redirect('student/show_all_students/'.$student[0]['class'].'/'.$student[0]['division']);
			}
			else {
				$this->input->set_cookie('message_code','4',1);
				redirect('student/show_all_students/'.$student[0]['class'].'/'.$student[0]['division']);
			}
		}
		else {
			redirect('login');
		}
	}

  public function change_class()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
      $data['view'] = 'student_change_class_view';
			$data['title'] = 'IQRA | Student';
			$data['breadcrumb_1'] = 'Student';
			$data['breadcrumb_2'] = 'Student';
			$data['breadcrumb_3'] = 'Change Class';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

	public function show_class_students()
	{
		$class = $this->input->post('class');
		$division = $this->input->post('division');

		// Fetching students based on class and devision
		$this->load->model('student_model');
		$list = $this->student_model->get_students($class,$division);

		// Storing student data into cookies to be displayed on table
		$this->input->set_cookie('student_count',count($list),10);
		for ($i=0; $i<count($list); $i++) {
			$this->input->set_cookie('student_'.$i.'_0',$list[$i]['gr_number'],10);
			$this->input->set_cookie('student_'.$i.'_1',$list[$i]['name'],10);
			$this->input->set_cookie('student_'.$i.'_2',$class,10);
			$this->input->set_cookie('student_'.$i.'_3',$division,10);
		}
		redirect('student/change_class');
	}

	public function update_class()
	{
		$grnumbers = explode(',',$this->input->post('grnumbers'));
		$class = $this->input->post('class');
		$division = $this->input->post('division');
		$passed_out = $this->input->post('passed_out');

		$this->load->model('student_model');
		$this->load->model('fees_model');

		if($class && $division){
			// Fetching students based on class and division
			for ($i=0; $i<count($grnumbers); $i++) {
				// Changing student class
				if($this->student_model->update_student_class($grnumbers[$i],$class,$division)){
					// Adding new records for new class students in fees tables
					$this->fees_model->change_class_term_one($grnumbers[$i]);
					$this->fees_model->change_class_term_two($grnumbers[$i]);

					$values = array(
						'gr_number' => $grnumbers[$i],
						'class' => $class,
						'division' => $division
					);

					$this->fees_model->add_student_entry($values);
				}
			}
			$this->input->set_cookie('message_code','2',1);
		}
		else {
			// Fetching students based on class and division
			for ($i=0; $i<count($grnumbers); $i++) {
				// Changing student passed out to 1
				if($this->student_model->update_student_passed_out($grnumbers[$i])){
					// Adding new records for new class students in fees tables
					$this->fees_model->change_class_term_one($grnumbers[$i]);
					$this->fees_model->change_class_term_two($grnumbers[$i]);
				}
			}
			$this->input->set_cookie('message_code','2',1);
		}
		redirect('student/change_class');
	}

}

?>
