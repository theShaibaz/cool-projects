<div class="row">
  <div class="col-12">
    <div class="card">
      <div class="card-body col-lg-4">
        <!-- <h4 class="card-title">Dropzone</h4> -->
        <h6 class="card-subtitle">select .txt file containing students data </h6>
        <form action="<?php echo base_url(); ?>import/import_file" method="post" enctype="multipart/form-data">
          <div class="">
            <input type="file" name="file" id="file" accept=".txt">
            <br><br><br>
            <button type="submit" id="import" class="btn btn-info btn-flat col-lg-8">Import Students</button>
          </div>
        </form>
      </div>
    </div>
  </div>
</div>

<?php

  // Showing toastr messages
  if($this->input->cookie('message_code')==2){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "info('Students imported','Successful');";
    echo "});";
    echo "</script>";
  }
  if($this->input->cookie('message_code')==3){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "warning('Select data file first','Check Input');";
    echo "});";
    echo "</script>";
  }
  if($this->input->cookie('message_code')==4){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "error('Students not imported','Unsuccessful');";
    echo "});";
    echo "</script>";
  }

?>
