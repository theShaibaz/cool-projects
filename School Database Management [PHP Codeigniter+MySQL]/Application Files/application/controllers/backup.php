<?php

class backup extends CI_Controller {

	public function index(){
    // Checking if session is active or not
		if(isset($this->session->isactive)){
			// Backup taken and saved to desktop 
			shell_exec('mysqldump -u root db_iqra > '.
							   getenv('HOMEDRIVE').getenv('HOMEPATH').
								 '\Desktop\iqra_backup_'.date('d-m-Y').'.sql');

			$this->input->set_cookie('message_code','2',1);
			redirect('dashboard');
		}
		else {
			redirect('login');
		}
	}

}

?>
