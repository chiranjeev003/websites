
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Feedback</title>
<style>
/* For mobile phones: */
[class*="col-"] {
    width: 100%;
}
@media only screen and (min-width: 600px) {
    /* For tablets: */
    .col-m-1 {width: 8.33%;}
    .col-m-2 {width: 16.66%;}
    .col-m-3 {width: 25%;}
    .col-m-4 {width: 33.33%;}
    .col-m-5 {width: 41.66%;}
    .col-m-6 {width: 50%;}
    .col-m-7 {width: 58.33%;}
    .col-m-8 {width: 66.66%;}
    .col-m-9 {width: 75%;}
    .col-m-10 {width: 83.33%;}
    .col-m-11 {width: 91.66%;}
    .col-m-12 {width: 100%;}
}
@media only screen and (min-width: 1200px) {
    /* For desktop: */
    .col-1 {width: 8.33%;}
    .col-2 {width: 16.66%;}
    .col-3 {width: 25%;}
    .col-4 {width: 33.33%;}
    .col-5 {width: 41.66%;}
    .col-6 {width: 50%;}
    .col-7 {width: 58.33%;}
    .col-8 {width: 66.66%;}
    .col-9 {width: 75%;}
    .col-10 {width: 83.33%;}
    .col-11 {width: 91.66%;}
    .col-12 {width: 100%;}
}
</style>
</head>
<link href="design.css" rel="stylesheet" type="text/css" />
<body style="background-color:#111111;">
<div class="row">
<form action="#" method="post">
	<div class="col-3 col-m-1 menu" style="margin-top:5%; float:left;">
	</div>
	<div class="col-6 col-m-10 menu" style=" float:left; background-color:#CCCCCC; height:90%; padding-bottom:4%; color:#FFFFFF; margin-top:5%; margin-bottom:5%;">
		<div style="color:#000000; margin-top:10%; z-index:100; text-align:center;" >
			Email-id:
			<input type="text" name="email" placeholder="Enter your Email-id" style="height:24px; width:375px;" />
		</div>
		<div style="color:#000000; margin-top:12%; z-index:100; text-align:center;">
			Feedback:
			
			<textarea rows="10" cols="50" name="feedback"> </textarea>
			
		</div>
		<div style="text-align:center">
		  <input type="submit" name="submit" value="SUBMIT" style="background-color:#C4C0F1; color:#000000; margin-top:12%; text-align:center; border-color:#000000; border-style:solid; height:30px; font-size:20px" />
		</div>
	</div>	
	<div class="col-3 col-m-1 menu" style="margin-top:5%; float:left;">
	</div> 
</form>
</div>
</body>
</html>
