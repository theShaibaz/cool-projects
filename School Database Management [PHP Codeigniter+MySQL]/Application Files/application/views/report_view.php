<div class="row justify-content-center">
  <div class="col-lg-12">
    <div class="card">
      <div class="card-body">
        <div class="form-validation">

          <form class="form-valide" id="form" action="" target="_blank" method="post">

            <div class="form-group row">
              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Report Options</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-4">
                    <input type="text" class="form-control" id="date" name="date"
                    placeholder="Date" style="text-align:center;">
                  </div>
                  <div class="col-lg-4">
                    <select class="form-control" id="class" name="class">
                      <option value="">Class</option>
                      <option value="First">First</option>
                      <option value="Second">Second</option>
                      <option value="Third">Third</option>
                      <option value="Forth">Forth</option>
                      <option value="Fifth">Fifth</option>
                      <option value="Sixth">Sixth</option>
                      <option value="Seventh">Seventh</option>
                      <option value="Eighth">Eighth</option>
                      <option value="Nineth">Nineth</option>
                      <option value="Tenth">Tenth</option>
                    </select>
                  </div>
                  <div class="col-lg-4">
                    <select class="form-control" id="division" name="division">
                      <option value="">Division</option>
                      <option value="A">A</option>
                      <option value="B">B</option>
                      <option value="C">C</option>
                      <option value="D">D</option>
                    </select>
                  </div>
                </div>
              </div>

              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Class Fees Report</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <button type="button" id="f_one" name="f_one" class="btn btn-info btn-flat col-lg-12">First Term</button>
                  </div>
                  <div class="col-lg-6">
                    <button type="button" id="f_two" name="f_two" class="btn btn-info btn-flat col-lg-12">Second Term</button>
                  </div>
                </div>
              </div>

              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Term / Month Fees Report</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <button type="button" id="i_day" name="i_day" class="btn btn-info btn-flat col-lg-12">Daily</button>
                  </div>
                  <div class="col-lg-6">
                    <button type="button" id="i_month" name="i_month" class="btn btn-info btn-flat col-lg-12">Monthly</button>
                  </div>
                </div>
              </div>

              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Income / Expense Report</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <button type="button" id="t_day" name="t_day" class="btn btn-info btn-flat col-lg-12">Daily</button>
                  </div>
                  <div class="col-lg-6">
                    <button type="button" id="t_month" name="t_month" class="btn btn-info btn-flat col-lg-12">Monthly</button>
                  </div>
                </div>
              </div>

            </div>
          </div>

          </form>
        </div>
      </div>
    </div>
  </div>
</div>
<!-- End Page Content -->

<?php

  echo "<script>";
  echo "$(document).ready(function(){";
  echo "$('#date').datepicker();";
  echo "$('#date').datepicker('option', 'dateFormat','dd-mm-yy');";
  if($this->input->cookie('dd')){
    $dd = $this->input->cookie('dd');
    $mm = $this->input->cookie('mm');
    $yy = $this->input->cookie('yy');
    echo "$('#date').datepicker('setDate','$dd-$mm-$yy');";
  }
  else {
    echo "$('#date').datepicker('setDate',new Date());";
  }
  echo "});";
  echo "</script>";

?>

<script>

    $(document).ready(function(){

      $("#t_day").click(function(){
        $("#form").prop("action","<?php echo base_url(); ?>report/transaction_daily");
        $("#form").submit();
      });

      $("#t_month").click(function(){
        $("#form").prop("action","<?php echo base_url(); ?>report/transaction_monthly");
        $("#form").submit();
      });

      $("#i_day").click(function(){
        $("#form").prop("action","<?php echo base_url(); ?>report/invoice_daily");
        $("#form").submit();
      });

      $("#i_month").click(function(){
        $("#form").prop("action","<?php echo base_url(); ?>report/invoice_monthly");
        $("#form").submit();
      });

      $("#f_one").click(function(){
        if($("#class").val()=='' || $("#division").val()==''){
          warning('Select class and division','Check Input');
        }
        else {
          $("#form").prop("action","<?php echo base_url(); ?>report/fees_one");
          $("#form").submit();
        }
      });

      $("#f_two").click(function(){
        if($("#class").val()=='' || $("#division").val()==''){
          warning('Select class and division','Check Input');
        }
        else {
          $("#form").prop("action","<?php echo base_url(); ?>report/fees_two");
          $("#form").submit();
        }
      });

    });

</script>

<?php

  // Showing toastr messages
  if($this->input->cookie('message_code')==1){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "success('New transaction added','Successful');";
    echo "});";
    echo "</script>";
  }
  if($this->input->cookie('message_code')==3){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "warning('* Marked fields are mendatory','Check Input');";
    echo "});";
    echo "</script>";
  }
  if($this->input->cookie('message_code')==4){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "error('Transaction not added','Unsuccessful');";
    echo "});";
    echo "</script>";
  }

?>
