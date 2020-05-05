<?php

class import extends CI_Controller {

	public function index(){
    // Checking if session is active or not
		if(isset($this->session->isactive)){
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
      $data['view'] = 'import_view';
			$data['title'] = 'IQRA | Import';
			$data['breadcrumb_1'] = 'Import';
			$data['breadcrumb_2'] = 'Import';
			$data['breadcrumb_3'] = 'Import Students';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

  public function import_file(){

    // Checking if session is active or not
		if(isset($this->session->isactive)){
			// Uploading file given by user to @root/data files folder
			// and then dumping the data into student table

			if($_FILES['file']['tmp_name']){
				move_uploaded_file($_FILES['file']['tmp_name'], 'data files/'.$_FILES['file']['name']);
	      $path = str_replace('\\','/',realpath('data files/'.$_FILES['file']['name']));

	      $this->load->database();
	      $query = $this->db->query("LOAD DATA LOCAL INFILE '".$path."'
	                        INTO TABLE tbl_students COLUMNS TERMINATED BY '\\t'");

				if($query){
					$this->input->set_cookie('message_code','2',1);
				}
				else {
					$this->input->set_cookie('message_code','4',1);
				}
			}
			else {
				$this->input->set_cookie('message_code','3',1);
			}

			redirect('import');

		}
		else {
			redirect('login');
		}
	}

}

?>
