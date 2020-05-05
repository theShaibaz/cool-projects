
<!-- Start Page Content -->
<div class="row justify-content-center">
  <div class="col-lg-12">
    <div class="card">
      <div class="card-body">
        <div class="form-validation">

          <!-- value="<?php echo $transaction[0]['id']; ?>" -->
          <!-- This line of code will restore previously entered value from $data array -->
          <form class="form-valide" action="<?php echo base_url(); ?>transaction/update_transaction" method="post">
            <div class="form-group row">
              <div class="col-lg-6">

                <input type="text" class="form-control" id="transaction_id" name="transaction_id"
                hidden value="<?php if($transaction[0]['id']){echo $transaction[0]['id'];} ?>">

                <h3 class="card-title m-t-15">Transaction</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>Type</label>
                    <input type="text" class="form-control" id="type" name="type"
                    disabled placeholder="Type" value="<?php if($transaction[0]['type']){echo $transaction[0]['type'];} ?>">
                  </div>
                  <div class="col-lg-6">
                    <label>Transaction of</label>
                    <input type="text" class="form-control" id="is_of" name="is_of"
                    disabled disabled placeholder="Transaction of" value="<?php if($transaction[0]['is_of']){echo $transaction[0]['is_of'];} ?>">
                  </div>
                </div>

                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>Date</label>
                    <input type="text" class="form-control" id="date" name="date"
                    disabled placeholder="Date" value="<?php if($transaction[0]['date']){echo $transaction[0]['dd'].'-'.$transaction[0]['mm'].'-'.$transaction[0]['yy'];} ?>">
                  </div>
                  <div class="col-lg-6">
                    <label>Amount</label>
                    <input type="text" class="form-control" id="amount" name="amount"
                    disabled placeholder="Amount" value="<?php if($transaction[0]['amount']){echo $transaction[0]['amount'];} ?>">
                  </div>
                </div>
              </div>

              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Payment</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>Payment Mode</label>
                    <input type="text" class="form-control" id="payment_mode" name="payment_mode"
                    disabled placeholder="Payment Mode" value="<?php if($transaction[0]['payment_mode']){echo $transaction[0]['payment_mode'];} ?>">
                  </div>
                  <div class="col-lg-6">
                    <label>Cheque Number</label>
                    <input type="text" class="form-control" id="cheque_number" name="cheque_number"
                    disabled placeholder="Cheque Number" value="<?php if($transaction[0]['cheque_number']){echo $transaction[0]['cheque_number'];} ?>">
                  </div>
                </div>

                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>IFSC Code</label>
                    <input type="text" class="form-control" id="ifsc_code" name="ifsc_code"
                    disabled placeholder="IFSC Code" value="<?php if($transaction[0]['ifsc_code']){echo $transaction[0]['ifsc_code'];} ?>">
                  </div>
                  <div class="col-lg-6">
                    <label>Comment</label>
                    <input type="text" class="form-control" id="comment" name="comment"
                    disabled placeholder="Comment" value="<?php if($transaction[0]['comment']){echo $transaction[0]['comment'];} ?>">
                  </div>
                </div>
              </div>
            </div>
          </div>

            <div class="form-group row">
              <div class="col-lg-8">
                <!-- <button type="submit" class="btn btn-info btn-flat offset-lg-6">Update Transaction</button> -->
                <button type="button" id="close" class="btn btn-dark btn-flat offset-lg-8 col-lg-2">Close</button>
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
  echo "$('#close').click(function(e){";
  echo "window.close();";
  echo "});";
  echo "});";
  echo "</script>";

?>

<?php

  // Showing toastr messages
  if($this->input->cookie('message_code')==1){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "success('Transaction updated','Successful');";
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
    echo "error('Transaction not updated','Unsuccessful');";
    echo "});";
    echo "</script>";
  }

?>
