<div class="row justify-content-center">
<div class="col-lg-12">
<div class="card">
    <div class="card-body">

          <!-- value="<?php echo $this->input->cookie('student_count'); ?>" -->
          <!-- This line of code will display details of students from cookie -->
          <form class="form-valide" action="<?php echo base_url(); ?>student/show_all_students" method="post">
            <div class="col-lg-12"><hr></div>
            <div class="col-lg-6">
              <div class="form-group row">
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
                </div>
              </div>
          </div>
          <div class="col-lg-12"><hr></div>
          </form>
        <div class="table-responsive m-t-40">
            <table id="example11" class="display nowrap table table-hover table-striped table-bordered" cellspacing="0" width="100%">
                <thead>
                    <tr>
                        <th>GR Number</th>
                        <th>Full Name</th>
                        <th>Class</th>
                        <th>Division</th>
                        <?php
                          if($this->session->username=='admin'||$this->session->username=='sudo'){
                            echo "<th>Edit / Delete</th>";
                          }
                          elseif ($this->session->username=='user') {
                            echo "<th>View</th>";
                          }
                        ?>
                    </tr>
                </thead>
                <tbody>
                  <?php
                  // Displaying all students by class and division selection
                  for ($i=0; $i<$this->input->cookie('student_count'); $i++) {
                    echo "<tr>";
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
                      echo "<td>";

                        if($this->session->username=='admin'||$this->session->username=='sudo'){
                          echo "<a href=".base_url()."student/edit/".
                          $this->input->cookie('student_'.$i.'_0')." target='_blank'>";
                          echo "<i class='fa fa-pencil fa-lg' aria-hidden='true'></i>";
                          echo "</a>";
                          echo "&nbsp;&nbsp;&nbsp;";
                          echo "<a href=".base_url()."student/delete_student/".$this->input->cookie('student_'.$i.'_0').">";
                          echo "<i class='fa fa-trash fa-lg' aria-hidden='true'></i>";
                          echo "</a>";
                        }
                        elseif ($this->session->username=='user') {
                          echo "<a href=".base_url()."student/show/".
                          $this->input->cookie('student_'.$i.'_0')." target='_blank'>";
                          echo "<i class='fa fa-eye fa-lg' aria-hidden='true'></i>";
                          echo "</a>";
                        }
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

<?php

  // Showing toastr messages
  if($this->input->cookie('message_code')==2){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "info('Student deleted','Successful');";
    echo "});";
    echo "</script>";
  }
  if($this->input->cookie('message_code')==4){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "error('Student not deleted','Unsuccessful');";
    echo "});";
    echo "</script>";
  }

?>
