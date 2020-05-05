        <div class="row">
            <div class="col-md-3">
                <div class="card p-30">
                    <div class="media">
                        <div class="media-left meida media-middle">
                            <span><i class="fa fa-inr f-s-40 color-primary"></i></span>
                        </div>
                        <div class="media-body media-text-right">
                            <h2><?php echo $income_day ?></h2>
                            <p class="m-b-0">Today</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="card p-30">
                    <div class="media">
                        <div class="media-left meida media-middle">
                            <span><i class="fa fa-inr f-s-40 color-primary"></i></span>
                        </div>
                        <div class="media-body media-text-right">
                            <h2><?php echo $income_month ?></h2>
                            <p class="m-b-0">This Month</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="card p-30">
                    <div class="media">
                        <div class="media-left meida media-middle">
                            <span><i class="fa fa-inr f-s-40 color-danger"></i></span>
                        </div>
                        <div class="media-body media-text-right">
                            <h2><?php echo $expense_day ?></h2>
                            <p class="m-b-0">Today</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="card p-30">
                    <div class="media">
                        <div class="media-left meida media-middle">
                            <span><i class="fa fa-inr f-s-40 color-danger"></i></span>
                        </div>
                        <div class="media-body media-text-right">
                            <h2><?php echo $expense_month ?></h2>
                            <p class="m-b-0">This Month</p>
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
            echo "info('Backup saved at Desktop','Successful');";
            echo "});";
            echo "</script>";
          }

        ?>
