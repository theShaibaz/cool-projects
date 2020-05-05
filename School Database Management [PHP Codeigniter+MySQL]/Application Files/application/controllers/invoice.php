<?php

require_once 'dompdf.php';
use Dompdf\Dompdf;

class invoice extends CI_Controller {

	public function index()
	{
		$data['view'] = 'page_not_found_view';
		$data['title'] = 'IQRA | Page Not Found';
		$data['breadcrumb_1'] = 'Page Not Found';
		$data['breadcrumb_2'] = 'Error';
		$data['breadcrumb_3'] = '404';
		$this->load->view('layout_view',$data);
	}

  public function create_new()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
      $data['view'] = 'invoice_create_new_view';
			$data['title'] = 'IQRA | Invoice';
			$data['breadcrumb_1'] = 'Invoice';
			$data['breadcrumb_2'] = 'Invoice';
			$data['breadcrumb_3'] = 'Create New';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

	public function show_students()
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
		redirect('invoice/create_new');
	}

	public function show_fees($grnumber,$class,$division)
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){

			$this->load->model('fees_model');
			$this->load->model('student_model');
			$term_one = $this->fees_model->get_fees_term_one($grnumber,$class,$division);
			$term_two = $this->fees_model->get_fees_term_two($grnumber,$class,$division);
			$name = $this->student_model->get_student($grnumber);

			// Storing fees details termwise and student name to be displayed
			$data['term_one'] = $term_one;
			$data['term_two'] = $term_two;
			$data['name'] = $name[0]['name'];
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
      $data['view'] = 'invoice_student_fees_view';
			$data['title'] = 'IQRA | Invoice';
			$data['breadcrumb_1'] = 'Invoice';
			$data['breadcrumb_2'] = 'Invoice';
			$data['breadcrumb_3'] = 'Show Fees';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

	public function create_new_invoice()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){

			$grnumber = $this->input->post('grnumber');
			$class = $this->input->post('class');
			$division = $this->input->post('division');
			// Storing termwise total amount got from input values
			$term_one_total = 0;
			$term_two_total = 0;

			// Storing term one fees values into fees table as well for invoice table
			// (particulars) and updating term one total value
			if($this->input->post('june')){
				$term_one_values['june'] = trim($this->input->post('june'),' ');
				$particulars['june'] = trim($this->input->post('june'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('june'),' ');
			}
			if($this->input->post('july')){
				$term_one_values['july'] = trim($this->input->post('july'),' ');
				$particulars['july'] = trim($this->input->post('july'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('july'),' ');
			}
			if($this->input->post('august')){
				$term_one_values['august'] = trim($this->input->post('august'),' ');
				$particulars['august'] = trim($this->input->post('august'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('august'),' ');
			}
			if($this->input->post('september')){
				$term_one_values['september'] = trim($this->input->post('september'),' ');
				$particulars['september'] = trim($this->input->post('september'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('september'),' ');
			}
			if($this->input->post('october')){
				$term_one_values['october'] = trim($this->input->post('october'),' ');
				$particulars['october'] = trim($this->input->post('october'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('october'),' ');
			}
			if($this->input->post('november')){
				$term_one_values['november'] = trim($this->input->post('november'),' ');
				$particulars['november'] = trim($this->input->post('november'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('november'),' ');
			}
			if($this->input->post('term_one')){
				$term_one_values['term'] = trim($this->input->post('term_one'),' ');
				$particulars['term_one'] = trim($this->input->post('term_one'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('term_one'),' ');
			}
			if($this->input->post('activity_one')){
				$term_one_values['activity'] = trim($this->input->post('activity_one'),' ');
				$particulars['activity_one'] = trim($this->input->post('activity_one'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('activity_one'),' ');
			}
			if($this->input->post('computer_one')){
				$term_one_values['computer'] = trim($this->input->post('computer_one'),' ');
				$particulars['computer_one'] = trim($this->input->post('computer_one'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('computer_one'),' ');
			}
			if($this->input->post('elearning_one')){
				$term_one_values['elearning'] = trim($this->input->post('elearning_one'),' ');
				$particulars['elearning_one'] = trim($this->input->post('elearning_one'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('elearning_one'),' ');
			}
			if($this->input->post('sport_one')){
				$term_one_values['sport'] = trim($this->input->post('sport_one'),' ');
				$particulars['sport_one'] = trim($this->input->post('sport_one'),' ');
				$term_one_total = $term_one_total + trim($this->input->post('sport_one'),' ');
			}
			// updated term one total = current input total + old total from db
			$term_one_values['total'] = $term_one_total + trim($this->input->post('total_one'),' ');

			// Storing term two fees values into fees table as well for invoice table
			// (particulars) and updating term two total value
			if($this->input->post('december')){
				$term_two_values['december'] = trim($this->input->post('december'),' ');
				$particulars['december'] = trim($this->input->post('december'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('december'),' ');
			}
			if($this->input->post('january')){
				$term_two_values['january'] = trim($this->input->post('january'),' ');
				$particulars['january'] = trim($this->input->post('january'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('january'),' ');
			}
			if($this->input->post('february')){
				$term_two_values['february'] = trim($this->input->post('february'),' ');
				$particulars['february'] = trim($this->input->post('february'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('february'),' ');
			}
			if($this->input->post('march')){
				$term_two_values['march'] = trim($this->input->post('march'),' ');
				$particulars['march'] = trim($this->input->post('march'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('march'),' ');
			}
			if($this->input->post('april')){
				$term_two_values['april'] = trim($this->input->post('april'),' ');
				$particulars['april'] = trim($this->input->post('april'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('april'),' ');
			}
			if($this->input->post('may')){
				$term_two_values['may'] = trim($this->input->post('may'),' ');
				$particulars['may'] = trim($this->input->post('may'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('may'),' ');
			}
			if($this->input->post('term_two')){
				$term_two_values['term'] = trim($this->input->post('term_two'),' ');
				$particulars['term_two'] = trim($this->input->post('term_two'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('term_two'),' ');
			}
			if($this->input->post('activity_two')){
				$term_two_values['activity'] = trim($this->input->post('activity_two'),' ');
				$particulars['activity_two'] = trim($this->input->post('activity_two'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('activity_two'),' ');
			}
			if($this->input->post('computer_two')){
				$term_two_values['computer'] = trim($this->input->post('computer_two'),' ');
				$particulars['computer_two'] = trim($this->input->post('computer_two'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('computer_two'),' ');
			}
			if($this->input->post('elearning_two')){
				$term_two_values['elearning'] = trim($this->input->post('elearning_two'),' ');
				$particulars['elearning_two'] = trim($this->input->post('elearning_two'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('elearning_two'),' ');
			}
			if($this->input->post('sport_two')){
				$term_two_values['sport'] = trim($this->input->post('sport_two'),' ');
				$particulars['sport_two'] = trim($this->input->post('sport_two'),' ');
				$term_two_total = $term_two_total + trim($this->input->post('sport_two'),' ');
			}
			// updated term two total = current input total + old total from db
			$term_two_values['total'] = $term_two_total + trim($this->input->post('total_two'),' ');

			// Checking if any fees amount is entered or not
			if($term_one_total || $term_two_total){
				// Updating student fees data
				$this->load->model('fees_model');
				$this->fees_model->update_fees_term_one($grnumber,$class,$division,$term_one_values);
				$this->fees_model->update_fees_term_two($grnumber,$class,$division,$term_two_values);

				// creating invoice
				$invoice_values = array(
					'id' => '0',
					'gr_number' => $grnumber,
					'class' => $class,
					'division' => $division,
					'date' => date('Y-m-d'),
					'particulars' => implode(' ',array_keys($particulars)),
					'amount' => implode(' ',$particulars),
					'grand_total' => $term_one_total + $term_two_total,
					'fees_help' => trim($this->input->post('fees_help'),' '),
					'comment' => trim($this->input->post('comment'),' ')
				);

				$this->load->model('invoice_model');
				if($this->invoice_model->add_invoice($invoice_values)){
					// Creating transaction
					$transaction_values = array(
						'id' => '0',
						'type' => 'Income',
						'is_of' => 'Fees Payment',
						'date' => date('Y-m-d'),
						'amount' => $term_one_total + $term_two_total,
						'payment_mode' => 'Cash'
					);

					$this->load->model('transaction_model');
					$this->transaction_model->add_transaction($transaction_values);

					$this->input->set_cookie('message_code','1',1);
					$id = $this->invoice_model->get_invoice_id();
					redirect('invoice/print_invoice/'.$id[0]['id']);
				}
				else {
					$this->input->set_cookie('message_code','4',1);
					redirect('invoice/show_fees/'.$grnumber.'/'.$class.'/'.$division);
				}
			}
			else {
				$this->input->set_cookie('message_code','3',1);
				redirect('invoice/show_fees/'.$grnumber.'/'.$class.'/'.$division);
			}
		}
		else {
			redirect('login');
		}
	}

  public function show_all()
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view

      $data['view'] = 'invoice_show_all_view';
			$data['title'] = 'IQRA | Invoice';
			$data['breadcrumb_1'] = 'Invoice';
			$data['breadcrumb_2'] = 'Invoice';
			$data['breadcrumb_3'] = 'Show All';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

	public function show_all_invoices()
	{
		$this->load->model('invoice_model');
		$list = $this->invoice_model->get_invoices();

		$this->load->model('student_model');

		// Getting invoice data and storing into cookies to display on table
		if(count($list)){
			$this->input->set_cookie('invoice_count',count($list),10);
		}
		else {
			$this->input->set_cookie('invoice_count','-1',10);
		}
		for ($i=0; $i<count($list); $i++) {
			$name = $this->student_model->get_every_student($list[$i]['gr_number']);
			$this->input->set_cookie('invoice_'.$i.'_0',$list[$i]['id'],10);
			$this->input->set_cookie('invoice_'.$i.'_1',$list[$i]['gr_number'],10);
			$this->input->set_cookie('invoice_'.$i.'_2',$name[0]['name'],10);
			$date = explode('-',$list[$i]['date']);
			$new_date = $date[2].'-'.$date[1].'-'.$date[0];
			$this->input->set_cookie('invoice_'.$i.'_3',$new_date,10);
			$this->input->set_cookie('invoice_'.$i.'_4',$list[$i]['grand_total'],10);

		}
		redirect('invoice/show_all');
	}

	public function show($id)
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			$this->load->model('invoice_model');
			$invoice = $this->invoice_model->get_invoice($id);

			$this->load->model('student_model');
			$name = $this->student_model->get_every_student($invoice[0]['gr_number']);

			// Formatting date as per datepicker jquery plugin
			$date = explode('-',$invoice[0]['date']);
			$invoice[0]['dd'] = $date[2];
			$invoice[0]['mm'] = $date[1];
			$invoice[0]['yy'] = $date[0];

			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
			$data['invoice'] = $invoice;
			$data['name'] = $name[0]['name'];
      $data['view'] = 'invoice_show_view';
			$data['title'] = 'IQRA | Invoice';
			$data['breadcrumb_1'] = 'Invoice';
			$data['breadcrumb_2'] = 'Invoice';
			$data['breadcrumb_3'] = 'Show';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}

	}

	public function delete_invoice($id)
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){
			$this->load->model('invoice_model');
			if($this->invoice_model->delete_invoice($id)){
				$this->input->set_cookie('message_code','2',1);
				redirect('invoice/show_all');
			}
			else {
				$this->input->set_cookie('message_code','4',1);
				redirect('invoice/show_all');
			}
		}
		else {
			redirect('login');
		}
	}

	public function print_invoice($id='')
	{
		// Checking if session is active or not
		if(isset($this->session->isactive)){

			if($id){
				$this->load->model('invoice_model');
				$invoice = $this->invoice_model->get_invoice($id);
				$this->load->model('student_model');
				$student = $this->student_model->get_every_student_full($invoice[0]['gr_number']);

				$id = $id;
				$grnumber = $invoice[0]['gr_number'];
				$name = $student[0]['name'];
				$class = $student[0]['class'];
				$division = $student[0]['division'];
				$date = explode('-',$invoice[0]['date']);
				$date = $date[2].'-'.$date[1].'-'.$date[0];
				$grand_total = $invoice[0]['grand_total'];
				$particulars = explode(' ',$invoice[0]['particulars']);
				$amount = explode(' ',$invoice[0]['amount']);
			}
			else {
				$id = $this->input->post('invoice_id');
				$grnumber = $this->input->post('grnumber');
				$name = $this->input->post('name');
				$class = $this->input->post('class');
				$division = $this->input->post('division');
				$date = $this->input->post('date');
				$grand_total = $this->input->post('grand_total');
				$particulars = explode(' ',$this->input->post('particulars'));
				$amount = explode(' ',$this->input->post('amount'));
			}

			$dhtml = '';
			for ($i=0; $i<count($particulars); $i++) {
				$dhtml = $dhtml .
								 "<tr style='width:700px;text-align:center'>
								 <td><br></td>
								 <td style='width:250px;text-align:left;'>".$particulars[$i]."</td>
								 <td style='width:250px;text-align:right;font:bold;border-left:1px solid black;'>".$amount[$i]."</td>
								 </tr>";
			}

			if(count($particulars)<15){
				for ($i=count($particulars); $i<=15; $i++) {
					$dhtml = $dhtml .
									 "<tr style='width:700px;text-align:center'>
									 <td><br></td>
									 <td><br></td>
									 <td style='border-left:1px solid black;'><br></td>
									 </tr>";
				}
			}

			$html = "
			<html>
				<body style='margin-left:25px;'>
					<table style='width:700px;'>

						<tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:25px;'>IQRA English Medium School</td>
						</tr>
						<tr style='width:700px;text-align:center;'>
							<td style='font-size:18px;'>Mirjole, Majgaon Road,</td>
						</tr>
						<tr style='width:700px;text-align:center;'>
							<td style='font-size:18px;'>Near Coast Guard Airport,</td>
						</tr>
						<tr style='width:700px;text-align:center;'>
							<td style='font-size:18px;'>Ratnagiri</td>
						</tr>
						<tr style='width:700px;text-align:center;'>
							<td style='font-size:15px;'>Email : iqraschoolratnagiri@gmail.com</td>
						</tr>
						<tr><td><br></td></tr>
						<tr><td><br></td></tr>
						<tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:20px;'>Fees Receipt</td>
						</tr>
						<tr><td><br></td></tr>

					</table>

					<table style='width:700px;font-size:17px;'>
						<tr style='width:700px;'>
							<td style='width:80px;'>Gr No.</td>
							<td style='width:400px;text-align:left;font:bold;'>: ".$grnumber."</td>

							<td style='width:80px;'>Invoice No.</td>
							<td style='width:100px;text-align:left;font:bold;'>: ".$id."</td>
						</tr>
						<tr style='width:700px;'>
							<td style='width:80px;'>Name</td>
							<td style='width:400px;text-align:left;font:bold;'>: ".$name."</td>

							<td style='width:80px;'>Date</td>
							<td style='width:100px;text-align:left;font:bold;'>: ".$date."</td>
						</tr>
						<tr style='width:700px;'>
							<td style='width:80px;'>Class</td>
							<td style='width:400px;text-align:left;font:bold;'>: ".$class."</td>

							<td></td>
							<td></td>
						</tr>
						<tr style='width:700px;'>
							<td style='width:80px;'>Division</td>
							<td style='width:400px;text-align:left;font:bold;'>: ".$division."</td>

							<td></td>
							<td></td>
						</tr>

					</table>

					<br>

					<table style='width:700px;border-collapse:collapse;font-size:17px;'>
						<tr style='width:700px;text-align:center'>
							<td style='width:200px;border-top:1px solid black;border-bottom:1px solid black;'><br></td>
							<td style='width:250px;text-align:left;border-top:1px solid black;border-bottom:1px solid black;'>Particulars</td>
							<td style='width:250px;text-align:right;border-left:1px solid black;border-top:1px solid black;border-bottom:1px solid black;'>Amount</td>
						</tr>
						<tr>
							<td><br></td>
							<td><br></td>
							<td style='border-left:1px solid black;'><br></td>
						</tr>
						<br>
						".$dhtml."
						<br>
						<tr style='width:700px;text-align:center'>
							<td style='width:200px;border-top:1px solid black;border-bottom:1px solid black;'><br></td>
							<td style='width:250px;text-align:center;border-top:1px solid black;border-bottom:1px solid black;'>Total</td>
							<td style='width:250px;text-align:right;font:bold;border-left:1px solid black;border-top:1px solid black;border-bottom:1px solid black;'>".$grand_total."</td>
						</tr>

					</table>

					<br><br><br><br><br><br>
					<div style='text-align:right;font-size:16px;margin-right:55px;'>Authorised Signatory</div>

					<footer>Developed by theShaibaz</footer>

				</body>
			</html>
			";

			// instantiate and use the dompdf class
			$dompdf = new Dompdf();
			$dompdf->loadHtml($html);

			// (Optional) Setup the paper size and orientation
			$dompdf->setPaper('A4', 'portrait');

			// Render the HTML as PDF
			$dompdf->render();

			// Output the generated PDF to Browser
			$dompdf->stream("invoice.pdf", array("Attachment" => false));

		}
		else {
			redirect('login');
		}
	}

}

?>
