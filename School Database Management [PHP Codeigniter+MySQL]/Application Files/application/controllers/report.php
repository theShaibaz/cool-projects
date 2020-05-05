<?php

require_once 'dompdf.php';
use Dompdf\Dompdf;

class report extends CI_Controller {

	public function index(){
    // Checking if session is active or not
		if(isset($this->session->isactive)){
			// Layout view is common view containing sidebar and navbar
			// in which respective view is loaded as main content view
      $data['view'] = 'report_view';
			$data['title'] = 'IQRA | Report';
			$data['breadcrumb_1'] = 'Report';
			$data['breadcrumb_2'] = 'Report';
			$data['breadcrumb_3'] = 'All Reports';
      $this->load->view('layout_view',$data);
		}
		else {
			redirect('login');
		}
	}

  public function transaction_daily(){
    // Checking if session is active or not
		if(isset($this->session->isactive)){

      $date = explode('-',$this->input->post('date'));
      $new_date = array($date[2],$date[1],$date[0]);
  		$new_date = implode('-',$new_date);
      echo $new_date;

      $this->load->model('transaction_model');
      $list = $this->transaction_model->get_transaction_by_day($new_date);

      $income_fees = 0;
      $income_misc = 0;
      $expense_misc = 0;

      for ($i=0; $i<count($list); $i++) {
        if($list[$i]['type']=='Income' && $list[$i]['is_of']=='Fees Payment'){
          $income_fees = $income_fees + $list[$i]['amount'];
        }
        elseif($list[$i]['type']=='Income' && $list[$i]['is_of']=='Miscellaneous') {
          $income_misc = $income_misc + $list[$i]['amount'];
        }
        elseif($list[$i]['type']=='Expense' && $list[$i]['is_of']=='Miscellaneous') {
          $expense_misc = $expense_misc + $list[$i]['amount'];
        }
      }

      // echo "<pre>";
      // print_r($list);
      // echo "\nIncome Fees : $income_fees";
      // echo "\nIncome Misc : $income_misc";
      // echo "\nExpense Misc : $expense_misc";
      // die;

      $html = "
			<html>
				<body style='margin-left:25px;'>
					<table style='width:700px;'>

						<tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:25px;'>IQRA English Medium School</td>
						</tr>
						<tr><td><br></td></tr>
						<tr style='width:700px;text-align:center;'>
							<td style='font-size:20px;'>Daily Income/Expense Report of</td>
						</tr>
            <tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:20px;'>".$this->input->post('date')."</td>
						</tr>
						<tr><td><br></td></tr>

					</table>

					<br>

					<table style='width:700px;border-collapse:collapse;font-size:17px;'>
						<tr style='width:700px;text-align:center'>
							<td style='font:bold;width:400px;border:1px solid black;'>Date</td>
              <td style='font:bold;width:100px;border:1px solid black;'>Income Fees</td>
              <td style='font:bold;width:100px;border:1px solid black;'>Income Misc</td>
              <td style='font:bold;width:100px;border:1px solid black;'>Expense</td>
						</tr>



            <tr style='width:700px;text-align:center'>
							<td style='width:400px;border:1px solid black;'>".$this->input->post('date')."</td>
              <td style='width:100px;border:1px solid black;'>".$income_fees."</td>
              <td style='width:100px;border:1px solid black;'>".$income_misc."</td>
              <td style='width:100px;border:1px solid black;'>".$expense_misc."</td>
						</tr>
					</table>

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
			$dompdf->stream("fees.pdf", array("Attachment" => false));

		}
		else {
			redirect('login');
		}
	}

  public function transaction_monthly(){
    // Checking if session is active or not
		if(isset($this->session->isactive)){

      $date = explode('-',$this->input->post('date'));
      $new_date = array($date[2],$date[1]);
  		$new_date = implode('-',$new_date);
      echo $new_date;

      $this->load->model('transaction_model');
      $list = $this->transaction_model->get_transaction_by_month($new_date);

      $dates = $this->transaction_model->get_distinct_dates($new_date);
      $dates_new = array();
      $values_income_fees = array();
      $values_income_misc = array();
      $values_expense_misc = array();
      for ($i=0; $i<count($dates); $i++) {
        $dates_new[$i] = $dates[$i]['date'];
      }
      $values_income_fees = array_fill_keys($dates_new,'0');
      $values_income_misc = array_fill_keys($dates_new,'0');
      $values_expense_misc = array_fill_keys($dates_new,'0');

      $income_fees = 0;
      $income_misc = 0;
      $expense_misc = 0;

      for ($i=0; $i<count($list); $i++) {
        if($list[$i]['type']=='Income' && $list[$i]['is_of']=='Fees Payment'){
          $income_fees = $income_fees + $list[$i]['amount'];
          $values_income_fees[$list[$i]['date']] += $list[$i]['amount'];
        }
        elseif($list[$i]['type']=='Income' && $list[$i]['is_of']=='Miscellaneous') {
          $income_misc = $income_misc + $list[$i]['amount'];
          $values_income_misc[$list[$i]['date']] += $list[$i]['amount'];
        }
        elseif($list[$i]['type']=='Expense' && $list[$i]['is_of']=='Miscellaneous') {
          $expense_misc = $expense_misc + $list[$i]['amount'];
          $values_expense_misc[$list[$i]['date']] += $list[$i]['amount'];
        }
      }

      // echo "<pre>";
      // print_r($values_income_fees);
      // print_r($values_income_misc);
      // print_r($values_expense_misc);
      // echo "\nIncome Fees : $income_fees";
      // echo "\nIncome Misc : $income_misc";
      // echo "\nExpense Misc : $expense_misc\n";
      // print_r($list);
      //
      // die;

      $dhtml = '';
			for ($i=0; $i<count($dates_new); $i++) {
        $d = explode('-',$dates_new[$i]);
				$dhtml = $dhtml .
								 "<tr style='width:700px;text-align:center;'>
                 <td style='width:400px;border:1px solid black;text-align:center;'>".$d[2]."-".$d[1]."-".$d[0]."</td>
                 <td style='width:100px;border:1px solid black;text-align:center;'>".$values_income_fees[$dates_new[$i]]."</td>
                 <td style='width:100px;border:1px solid black;text-align:center;'>".$values_income_misc[$dates_new[$i]]."</td>
                 <td style='width:100px;border:1px solid black;text-align:center;'>".$values_expense_misc[$dates_new[$i]]."</td>
								 </tr>";
			}

			$html = "
			<html>
				<body style='margin-left:25px;'>
					<table style='width:700px;'>

						<tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:25px;'>IQRA English Medium School</td>
						</tr>
						<tr><td><br></td></tr>
						<tr style='width:700px;text-align:center;'>
							<td style='font-size:20px;'>Monthly Income/Expense Report of</td>
						</tr>
            <tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:20px;'>".$date[1]."-".$date[2]."</td>
						</tr>
						<tr><td><br></td></tr>

					</table>

					<br>

					<table style='width:700px;border-collapse:collapse;font-size:17px;'>
						<tr style='width:700px;text-align:center'>
							<td style='font:bold;width:400px;border:1px solid black;'>Date</td>
              <td style='font:bold;width:100px;border:1px solid black;'>Income Fees</td>
              <td style='font:bold;width:100px;border:1px solid black;'>Income Misc</td>
              <td style='font:bold;width:100px;border:1px solid black;'>Expense</td>
						</tr>

						<br>
						".$dhtml."
            <br>

            <tr style='width:700px;text-align:center'>
							<td style='font:bold;width:400px;border:1px solid black;'>Total</td>
              <td style='font:bold;width:100px;border:1px solid black;'>".$income_fees."</td>
              <td style='font:bold;width:100px;border:1px solid black;'>".$income_misc."</td>
              <td style='font:bold;width:100px;border:1px solid black;'>".$expense_misc."</td>
						</tr>
					</table>

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
			$dompdf->stream("fees.pdf", array("Attachment" => false));

		}
		else {
			redirect('login');
		}
	}

  public function invoice_daily(){
    // Checking if session is active or not
		if(isset($this->session->isactive)){

      $date = explode('-',$this->input->post('date'));
      $new_date = array($date[2],$date[1],$date[0]);
  		$new_date = implode('-',$new_date);
      echo $new_date;

      $this->load->model('invoice_model');
      $list = $this->invoice_model->get_invoice_by_day($new_date);

      $months = array('january','february','march','april','may','june',
                      'july','august','september','october','november','december');
      $terms = array('term_one','activity_one','computer_one','elearning_one','sport_one',
                     'term_two','activity_two','computer_two','elearning_two','sport_two');
      $monthly_fees = 0;
      $term_fees = 0;

      for ($i=0; $i<count($list); $i++) {
        $particulars = explode(' ',$list[$i]['particulars']);
        $amount = explode(' ',$list[$i]['amount']);

        for ($j=0; $j<count($particulars); $j++) {
          if(in_array($particulars[$j],$months)){
            $monthly_fees = $monthly_fees + $amount[$j];
          }
          elseif(in_array($particulars[$j],$terms)) {
            $term_fees = $term_fees + $amount[$j];
          }
        }
      }

      // echo "<pre>";
      // print_r($list);
      // echo "\nMonthly Fees : $monthly_fees";
      // echo "\nTerm Fees : $term_fees";
      // die;


			$html = "
			<html>
				<body style='margin-left:25px;'>
					<table style='width:700px;'>

						<tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:25px;'>IQRA English Medium School</td>
						</tr>
						<tr><td><br></td></tr>
						<tr style='width:700px;text-align:center;'>
							<td style='font-size:20px;'>Daily Fees Report of</td>
						</tr>
            <tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:20px;'>".$this->input->post('date')."</td>
						</tr>
						<tr><td><br></td></tr>

					</table>

					<br>

					<table style='width:700px;border-collapse:collapse;font-size:17px;'>
						<tr style='width:700px;text-align:center'>
							<td style='font:bold;width:300px;border:1px solid black;'>Date</td>
              <td style='font:bold;width:200px;border:1px solid black;'>Term Fees</td>
              <td style='font:bold;width:200px;border:1px solid black;'>Month Fees</td>
						</tr>



            <tr style='width:700px;text-align:center'>
							<td style='width:300px;border:1px solid black;'>".$this->input->post('date')."</td>
              <td style='width:200px;border:1px solid black;'>".$term_fees."</td>
              <td style='width:200px;border:1px solid black;'>".$monthly_fees."</td>
						</tr>
					</table>

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
			$dompdf->stream("fees.pdf", array("Attachment" => false));

		}
		else {
			redirect('login');
		}
	}

  public function invoice_monthly(){
    // Checking if session is active or not
		if(isset($this->session->isactive)){

      $date = explode('-',$this->input->post('date'));
      $new_date = array($date[2],$date[1]);
  		$new_date = implode('-',$new_date);
      echo $new_date;

      $this->load->model('invoice_model');
      $list = $this->invoice_model->get_invoice_by_month($new_date);

      $dates = $this->invoice_model->get_distinct_dates($new_date);
      $dates_new = array();
      $values_monthly_fees = array();
      $values_term_fees = array();
      for ($i=0; $i<count($dates); $i++) {
        $dates_new[$i] = $dates[$i]['date'];
      }
      $values_monthly_fees = array_fill_keys($dates_new,'0');
      $values_term_fees = array_fill_keys($dates_new,'0');
      // echo "<pre>";
      // print_r($dates_new);die;

      $months = array('january','february','march','april','may','june',
                      'july','august','september','october','november','december');
      $terms = array('term_one','activity_one','computer_one','elearning_one','sport_one',
                     'term_two','activity_two','computer_two','elearning_two','sport_two');
      $monthly_fees = 0;
      $term_fees = 0;

      for ($i=0; $i<count($list); $i++) {
        $particulars = explode(' ',$list[$i]['particulars']);
        $amount = explode(' ',$list[$i]['amount']);

        for ($j=0; $j<count($particulars); $j++) {
          if(in_array($particulars[$j],$months)){
            $monthly_fees = $monthly_fees + $amount[$j];
            $values_monthly_fees[$list[$i]['date']] += $amount[$j];
          }
          elseif(in_array($particulars[$j],$terms)) {
            $term_fees = $term_fees + $amount[$j];
            $values_term_fees[$list[$i]['date']] += $amount[$j];
          }
        }
      }

      // echo "<pre>";
      // print_r($values_monthly_fees);
      // print_r($values_term_fees);
      // echo "\nMonthly Fees : $monthly_fees";
      // echo "\nTerm Fees : $term_fees\n";
      // print_r($list);
      //
      // die;

      // $this->load->model('student_model');

      $dhtml = '';
			for ($i=0; $i<count($dates_new); $i++) {
        $d = explode('-',$dates_new[$i]);
				$dhtml = $dhtml .
								 "<tr style='width:700px;text-align:center;'>
                 <td style='width:300px;border:1px solid black;text-align:center;'>".$d[2]."-".$d[1]."-".$d[0]."</td>
                 <td style='width:200px;border:1px solid black;text-align:center;'>".$values_term_fees[$dates_new[$i]]."</td>
                 <td style='width:200px;border:1px solid black;text-align:center;'>".$values_monthly_fees[$dates_new[$i]]."</td>
								 </tr>";
			}

			$html = "
			<html>
				<body style='margin-left:25px;'>
					<table style='width:700px;'>

						<tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:25px;'>IQRA English Medium School</td>
						</tr>
						<tr><td><br></td></tr>
						<tr style='width:700px;text-align:center;'>
							<td style='font-size:20px;'>Monthly Fees Report of</td>
						</tr>
            <tr style='width:700px;text-align:center;'>
							<td style='font:bold;font-size:20px;'>".$date[1]."-".$date[2]."</td>
						</tr>
						<tr><td><br></td></tr>

					</table>

					<br>

					<table style='width:700px;border-collapse:collapse;font-size:17px;'>
						<tr style='width:700px;text-align:center'>
							<td style='font:bold;width:300px;border:1px solid black;'>Date</td>
              <td style='font:bold;width:200px;border:1px solid black;'>Term Fees</td>
              <td style='font:bold;width:200px;border:1px solid black;'>Month Fees</td>
						</tr>

						<br>
						".$dhtml."
            <br>

            <tr style='width:700px;text-align:center'>
							<td style='font:bold;width:300px;border:1px solid black;'>Total</td>
              <td style='font:bold;width:200px;border:1px solid black;'>".$term_fees."</td>
              <td style='font:bold;width:200px;border:1px solid black;'>".$monthly_fees."</td>
						</tr>
					</table>

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
			$dompdf->stream("fees.pdf", array("Attachment" => false));

		}
		else {
			redirect('login');
		}
	}

  public function fees_one(){
    // Checking if session is active or not
		if(isset($this->session->isactive)){
      $class = $this->input->post('class');
      $division = $this->input->post('division');

      $this->load->model('fees_model');
      $list = $this->fees_model->get_all_term_one($class,$division);

      $this->load->model('student_model');

      $dhtml = '';
			for ($i=0; $i<count($list); $i++) {
        $name = $this->student_model->get_student($list[$i]['gr_number']);
				$dhtml = $dhtml .
								 "<tr style='width:1100px;text-align:center;'>
                 <td style='font:bold;width:150px;border:1px solid black;text-align:left;'>".$name[0]['name']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['term']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['activity']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['computer']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['elearning']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['sport']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['june']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['july']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['august']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['september']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['october']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['november']."</td>
                 <td style='font:bold;width:50px;border:1px solid black;'>".$list[$i]['total']."</td>
								 </tr>";
			}

			$html = "
			<html>
				<body>
					<table style='width:1100px;'>

						<tr style='width:1100px;text-align:center;'>
							<td style='font:bold;font-size:25px;'>IQRA English Medium School</td>
						</tr>
						<tr><td><br></td></tr>
						<tr style='width:1100px;text-align:center;'>
							<td style='font-size:20px;'>Fees Report of Class <b>".$class." ".$division."</b></td>
						</tr>
            <tr style='width:1100px;text-align:center;'>
							<td style='font:bold;font-size:20px;'>First Term</td>
						</tr>
						<tr><td><br></td></tr>

					</table>

					<br>

					<table style='width:1100px;border-collapse:collapse;font-size:17px;'>
						<tr style='width:1100px;text-align:center'>
							<td style='font:bold;width:150px;border:1px solid black;'>Name</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Term</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Act</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Comp</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Elearn</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Sport</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Jun</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Jul</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Aug</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Sept</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Oct</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Nov</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Total</td>
						</tr>

						<br>
						".$dhtml."

					</table>

					<footer>Developed by theShaibaz</footer>

				</body>
			</html>
			";

			// instantiate and use the dompdf class
			$dompdf = new Dompdf();
			$dompdf->loadHtml($html);

			// (Optional) Setup the paper size and orientation
			$dompdf->setPaper('A4', 'landscape');

			// Render the HTML as PDF
			$dompdf->render();

			// Output the generated PDF to Browser
			$dompdf->stream("fees.pdf", array("Attachment" => false));

    }
		else {
			redirect('login');
		}
  }

  public function fees_two(){
    // Checking if session is active or not
		if(isset($this->session->isactive)){
      $class = $this->input->post('class');
      $division = $this->input->post('division');

      $this->load->model('fees_model');
      $list = $this->fees_model->get_all_term_two($class,$division);

      $this->load->model('student_model');

      $dhtml = '';
			for ($i=0; $i<count($list); $i++) {
        $name = $this->student_model->get_student($list[$i]['gr_number']);
				$dhtml = $dhtml .
								 "<tr style='width:1100px;text-align:center;'>
                 <td style='font:bold;width:150px;border:1px solid black;text-align:left;'>".$name[0]['name']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['term']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['activity']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['computer']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['elearning']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['sport']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['december']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['january']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['february']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['march']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['april']."</td>
                 <td style='width:50px;border:1px solid black;'>".$list[$i]['may']."</td>
                 <td style='font:bold;width:50px;border:1px solid black;'>".$list[$i]['total']."</td>
								 </tr>";
			}

			$html = "
			<html>
				<body>
					<table style='width:1100px;'>

						<tr style='width:1100px;text-align:center;'>
							<td style='font:bold;font-size:25px;'>IQRA English Medium School</td>
						</tr>
						<tr><td><br></td></tr>
						<tr style='width:1100px;text-align:center;'>
							<td style='font-size:20px;'>Fees Report of Class <b>".$class." ".$division."</b></td>
						</tr>
            <tr style='width:1100px;text-align:center;'>
							<td style='font:bold;font-size:20px;'>Second Term</td>
						</tr>
						<tr><td><br></td></tr>

					</table>

					<br>

					<table style='width:1100px;border-collapse:collapse;font-size:17px;'>
						<tr style='width:1100px;text-align:center'>
							<td style='font:bold;width:150px;border:1px solid black;'>Name</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Term</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Act</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Comp</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Elearn</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Sport</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Dec</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Jan</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Feb</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Mar</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Apr</td>
              <td style='font:bold;width:50px;border:1px solid black;'>May</td>
              <td style='font:bold;width:50px;border:1px solid black;'>Total</td>
						</tr>

						<br>
						".$dhtml."

					</table>

					<footer>Developed by theShaibaz</footer>

				</body>
			</html>
			";

			// instantiate and use the dompdf class
			$dompdf = new Dompdf();
			$dompdf->loadHtml($html);

			// (Optional) Setup the paper size and orientation
			$dompdf->setPaper('A4', 'landscape');

			// Render the HTML as PDF
			$dompdf->render();

			// Output the generated PDF to Browser
			$dompdf->stream("fees.pdf", array("Attachment" => false));

    }
		else {
			redirect('login');
		}
  }

}

?>
