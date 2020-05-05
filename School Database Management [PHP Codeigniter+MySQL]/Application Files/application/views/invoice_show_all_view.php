<div class="row justify-content-center">
<div class="col-lg-12">
<div class="card">
  <div class="card-body">

    <!-- value="<?php echo $this->input->cookie('transaction_count'); ?>" -->
    <!-- This line of code will display values of transactions from cookie -->
    <form class="form-valide">
        <div class="table-responsive m-t-40">
            <table id="example11" class="display nowrap table table-hover table-striped table-bordered" cellspacing="0" width="100%">
                <thead>
                    <tr>
                        <th>Invoice ID</th>
                        <th>GR Number</th>
                        <th>Full Name</th>
                        <th>Date</th>
                        <th>Grand Total</th>
                        <th>View / Print</th>
                    </tr>
                </thead>
                <tbody>
                  <?php
                  // Displaying invoices to the table
                  for ($i=0; $i<$this->input->cookie('invoice_count'); $i++) {
                    echo "<tr>";
                      echo "<td>";
                        echo $this->input->cookie('invoice_'.$i.'_0');
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('invoice_'.$i.'_1');
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('invoice_'.$i.'_2');
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('invoice_'.$i.'_3');
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('invoice_'.$i.'_4');
                      echo "</td>";
                      echo "<td>";
                        echo "<a href=".base_url()."invoice/show/".
                        $this->input->cookie('invoice_'.$i.'_0')." target='_blank'>";
                        echo "<i class='fa fa-eye fa-lg' aria-hidden='true'></i>";
                        echo "</a>";
                        echo "&nbsp;&nbsp;&nbsp;";
                        echo "<a href=".base_url()."invoice/print_invoice/".
                        $this->input->cookie('invoice_'.$i.'_0')." target='_blank'>";
                        echo "<i class='fa fa-print fa-lg' aria-hidden='true'></i>";
                        echo "</a>";
                      echo "</td>";

                    echo "</tr>";
                  }

                  ?>
                </tbody>
            </table>
        </div>
    </div>
</div>
</div>
</div>

<script>

    $(document).ready(function(){
      <?php
        if(!$this->input->cookie('invoice_count')){
          echo "window.location.href = '".base_url()."invoice/show_all_invoices'";
        }
      ?>
    });

</script>

<?php

  // Showing toastr messages
  if($this->input->cookie('message_code')==2){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "info('Invoice deleted','Successful');";
    echo "});";
    echo "</script>";
  }
  if($this->input->cookie('message_code')==4){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "error('Invoice not deleted','Unsuccessful');";
    echo "});";
    echo "</script>";
  }

?>
