<div class="row justify-content-center">
<div class="col-lg-12">
<div class="card">
    <div class="card-body">

          <!-- value="<?php echo $this->input->cookie('student_count'); ?>" -->
          <!-- This line of code will display details of students from cookie -->
          <form class="form-valide" id="form" action="<?php echo base_url(); ?>student/show_class_students" method="post">
            <div class="col-lg-12"><hr></div>
            <div class="col-lg-6">
              <div class="form-group row">

                <input type="text" id="count" name="count" value="<?php echo $this->input->cookie('student_count');?>" hidden>
                <input type="text" id="grnumbers" name="grnumbers" hidden>

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
                <div class="col-lg-4">
                  <button type="submit" id="list" class="btn btn-info btn-flat">List Students</button>
                  <button type="button" id="change" class="btn btn-info btn-flat" hidden>Change Class</button>
                </div>
                <br><br>
                <div class="col-lg-4">
                  <label for="passed_out" id="pass" hidden><input type="checkbox" class="css-control-input"
                  id="passed_out" name="passed_out" value=""> Passed out</label>
                </div>
              </div>
          </div>
          <div class="col-lg-12"><hr></div>
          </form>
        <div class="table-responsive m-t-40">
            <table id="example11" class="display nowrap table table-hover table-striped table-bordered" cellspacing="0" width="100%">
                <thead>
                    <tr>
                        <th>
                          <?php
                            if($this->input->cookie('student_count')>0){
                              echo "<input type='checkbox' class='css-control-input'
                              id='checkmain' name='checkmain' value=''></th>";
                            }
                          ?>
                        <th>GR Number</th>
                        <th>Full Name</th>
                        <th>Class</th>
                        <th>Division</th>
                    </tr>
                </thead>
                <tbody>
                  <?php

                  for ($i=0; $i<$this->input->cookie('student_count'); $i++) {
                    echo "<tr>";
                      echo "<td>";
                          echo "<input type='checkbox' class='css-control-input checkbox'
                          id='".$this->input->cookie('student_'.$i.'_0')."'
                          name='".$this->input->cookie('student_'.$i.'_0')."'>";
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('student_'.$i.'_0');
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('student_'.$i.'_1');
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('student_'.$i.'_2');
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('student_'.$i.'_3');
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

      $("#checkmain").click(function(){
        if($(this).prop("checked")==true){
          $(".checkbox").prop("checked",true);

          $("#list").prop("hidden",true);
          $("#change").prop("hidden",false);
          $("#pass").prop("hidden",false);
        }
        else{
          $(".checkbox").prop("checked",false);

          $("#list").prop("hidden",false);
          $("#change").prop("hidden",true);
          $("#pass").prop("hidden",true);
        }
      });

      $(".checkbox").click(function(){
        var count = 0;
        var total_count = $("#count").val();

        $(".checkbox").each(function(index){
          if($(this).prop("checked")==true){
            count++;
          }

          if(count>0){
            $("#list").prop("hidden",true);
            $("#change").prop("hidden",false);
            $("#pass").prop("hidden",false);
          }
          else {
            $("#list").prop("hidden",false);
            $("#change").prop("hidden",true);
            $("#pass").prop("hidden",true);
          }

          if(count==total_count){
            $("#checkmain").prop("checked",true);
          }
          else{
            $("#checkmain").prop("checked",false);
          }
        });
      });

      $("#change").click(function(){
        var cls = $("#class").val();
        var div = $("#division").val();
        var passed_out = $("#passed_out").prop("checked");

        if((cls=='' || div=='') && passed_out==false){
          warning('Select new class and division','Check Input');
        }
        else{
          var grnumbers = new Array();
          $(".checkbox").each(function(index){
            if($(this).prop("checked")==true){
              grnumbers.push($(this).prop("id"));
            }
          });

          $("#grnumbers").val(grnumbers);
          $("#form").prop("action","<?php echo base_url(); ?>student/update_class");
          $("#form").submit();

        }
      });

      $("#passed_out").click(function(){
        if($(this).prop("checked")==true){
          $("#class").prop("disabled",true);
          $("#division").prop("disabled",true);
        }
        else {
          $("#class").prop("disabled",false);
          $("#division").prop("disabled",false);
        }

      });

    });

</script>

<?php

  // Showing toastr messages
  if($this->input->cookie('message_code')==2){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "info('Class changed','Successful');";
    echo "});";
    echo "</script>";
  }
  if($this->input->cookie('message_code')==4){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "error('Class not changed','Unsuccessful');";
    echo "});";
    echo "</script>";
  }

?>
