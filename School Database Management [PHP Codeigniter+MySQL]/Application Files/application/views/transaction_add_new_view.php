
<!-- Start Page Content -->
<div class="row justify-content-center">
  <div class="col-lg-12">
    <div class="card">
      <div class="card-body">
        <div class="form-validation">

          <!-- value="<?php echo $this->input->cookie('type'); ?>" -->
          <!-- This line of code will restore previously entered value from cookie -->
          <form class="form-valide" action="<?php echo base_url(); ?>transaction/add_new_transaction" method="post">
            <div class="form-group row">
              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Transaction</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>Type <span style="color:red">*</span></label>
                    <select class="form-control" id="type" name="type">
                      <option value="">Select Type</option>
                      <option value="income" <?php if($this->input->cookie('type')=='income'){echo "selected";}?>>Income</option>
                      <option value="expense" <?php if($this->input->cookie('type')=='expense'){echo "selected";}?>>Expense</option>
                    </select>
                  </div>
                  <div class="col-lg-6">
                    <label>Transaction of <span style="color:red">*</span></label>
                    <select class="form-control" id="is_of" name="is_of">
                      <option value="">Select Transaction of</option>
                      <option value="fees payment" <?php if($this->input->cookie('is_of')=='fees payment'){echo "selected";}?>>Fees Payment</option>
                      <option value="miscellaneous" <?php if($this->input->cookie('is_of')=='miscellaneous'){echo "selected";}?>>Miscellaneous</option>
                    </select>
                  </div>
                </div>

                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>Date <span style="color:red">*</span></label>
                    <input type="text" class="form-control" id="date" name="date"
                    placeholder="Date">
                  </div>
                  <div class="col-lg-6">
                    <label>Amount <span style="color:red">*</span></label>
                    <input type="text" class="form-control" id="amount" name="amount"
                    placeholder="Enter Amount" value="<?php echo $this->input->cookie('amount'); ?>">
                  </div>
                </div>
              </div>

              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Payment</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>Payment Mode <span style="color:red">*</span></label>
                    <select class="form-control" id="payment_mode" name="payment_mode">
                      <option value="">Select Payment Mode</option>
                      <option value="cash" <?php if($this->input->cookie('payment_mode')=='cash'){echo "selected";}?>>Cash</option>
                      <option value="cheque" <?php if($this->input->cookie('payment_mode')=='cheque'){echo "selected";}?>>Cheque</option>
                    </select>
                  </div>
                  <div class="col-lg-6">
                    <label>Cheque Number</label>
                    <input type="text" class="form-control" id="cheque_number" name="cheque_number"
                    placeholder="Enter Cheque Number">
                  </div>
                </div>

                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>IFSC Code</label>
                    <input type="text" class="form-control" id="ifsc_code" name="ifsc_code"
                    placeholder="Enter IFSC Code">
                  </div>
                  <div class="col-lg-6">
                    <label>Comment</label>
                    <input type="text" class="form-control" id="comment" name="comment"
                    placeholder="Enter Comment">
                  </div>
                </div>
              </div>
            </div>
          </div>

            <div class="form-group row">
              <div class="col-lg-8">
                <button type="submit" class="btn btn-info btn-flat offset-lg-6">Add Transaction</button>
                <button type="reset" id='reset' class="btn btn-dark btn-flat">Reset</button>
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
