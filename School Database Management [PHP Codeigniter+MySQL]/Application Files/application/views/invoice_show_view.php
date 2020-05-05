
<!-- Start Page Content -->
<div class="row justify-content-center">
  <div class="col-lg-12">
    <div class="card">
      <div class="card-body">
        <div class="form-validation">

          <!-- value="<?php echo $invoice[0]['id']; ?>" -->
          <!-- This line of code will restore previously entered value from $data array -->
          <form class="form-valide" action="<?php echo base_url(); ?>invoice/print_invoice" target="_blank" method="post">
            <div class="form-group row">
              <div class="col-lg-12">

                <input type="text" class="form-control" id="invoice_id" name="invoice_id"
                hidden value="<?php if($invoice[0]['id']){echo $invoice[0]['id'];} ?>">

                <h3 class="card-title m-t-15">Student</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-3">
                    <label>GR Number</label>
                    <input type="text" class="form-control" id="grnumber" name="grnumber"
                    readonly placeholder="GR Number" value="<?php if($invoice[0]['gr_number']){echo $invoice[0]['gr_number'];} ?>">
                  </div>
                  <div class="col-lg-3">
                  <label>Full Name</label>
                  <input type="text" class="form-control" id="name" name="name"
                  readonly placeholder="Full Name" value="<?php if($name){echo $name;} ?>">
                </div>

                <div class="col-lg-3">
                  <label>Class</label>
                  <input type="text" class="form-control" id="class" name="class"
                  readonly placeholder="Class" value="<?php if($invoice[0]['class']){echo $invoice[0]['class'];} ?>">
                </div>
                <div class="col-lg-3">
                  <label>Division</label>
                  <input type="text" class="form-control" id="division" name="division"
                  readonly placeholder="Division" value="<?php if($invoice[0]['division']){echo $invoice[0]['division'];} ?>">
                </div>
              </div>
            </div>

            <div class="col-lg-6">
              <h3 class="card-title m-t-15">Particulars</h3>
              <hr>

              <div class="form-group row">
                <div class="col-lg-6">
                  <label>Particulars</label>
                  <textarea class="form-control" rows="5" id="particulars" name="particulars" readonly placeholder="Particulars" style="height:83%;"><?php if($invoice[0]['particulars']){echo $invoice[0]['particulars'];} ?></textarea>
                </div>
                <div class="col-lg-6">
                  <label>Amount</label>
                  <textarea class="form-control" rows="5" id="amount" name="amount" readonly placeholder="Amount" style="height:83%;"><?php if($invoice[0]['amount']){echo $invoice[0]['amount'];} ?></textarea>
                </div>
              </div>
            </div>

            <div class="col-lg-6">
              <h3 class="card-title m-t-15">Invoice</h3>
              <hr>

              <div class="form-group row">
                <div class="col-lg-6">
                  <label>Date</label>
                  <input type="text" class="form-control" id="date" name="date"
                  readonly placeholder="Date" value="<?php if($invoice[0]['date']){echo $invoice[0]['dd'].'-'.$invoice[0]['mm'].'-'.$invoice[0]['yy'];} ?>">
                </div>
                <div class="col-lg-6">
                  <label>Grand Total</label>
                  <input type="text" class="form-control" id="grand_total" name="grand_total"
                  readonly placeholder="Grand Total" value="<?php if($invoice[0]['grand_total']){echo $invoice[0]['grand_total'];} ?>">
                </div>
              </div>

              <div class="form-group row">
                <div class="col-lg-6">
                  <label>Fees Help</label>
                  <input type="text" class="form-control" id="fees_help" name="fees_help"
                  readonly placeholder="Fees Help" value="<?php if($invoice[0]['fees_help']){echo $invoice[0]['fees_help'];} ?>">
                </div>
                <div class="col-lg-6">
                  <label>Comment</label>
                  <input type="text" class="form-control" id="comment" name="comment"
                  readonly placeholder="Comment" value="<?php if($invoice[0]['comment']){echo $invoice[0]['comment'];} ?>">
                </div>
              </div>

            </div>
          </div>
        </div>

        <div class="form-group row">
          <div class="col-lg-8">
            <button type="submit" class="btn btn-info btn-flat offset-lg-7">Print Invoice</button>
            <button type="button" id="close" class="btn btn-dark btn-flat">Close</button>
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
    echo "success('Invoice updated','Successful');";
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
    echo "error('Invoice not updated','Unsuccessful');";
    echo "});";
    echo "</script>";
  }

?>
