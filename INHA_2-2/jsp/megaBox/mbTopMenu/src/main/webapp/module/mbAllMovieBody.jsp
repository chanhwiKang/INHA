<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<style>
	h2.tit {
	    padding: 0 0 26px 0;
	    font-size: 1.8666em;
	    font-weight: 400;
	    letter-spacing: -1px;
	    line-height: 1.1;
	    color: #222;
	    height: 0px;
	}
	.btn-primary{
		width: 245px;
		background: #037b94;
	}
	.content-container{
		max-width: 1200px;
		display: flex;
		justify-content: center;
		margin: 0 auto; /* 중앙 정렬을 위한 마진 */
		margin-top: 20px;
		margin-bottom: 10px;
		gap: 39px;
	}
	.poster{
		border-radius: 5%;
		margin-bottom: 10px;
	}
	.poster-div{
		position: relative;
	}
	.rank{
		position: absolute;
	    left: 0;
	    top: 0;
	    width: 100%;
	    height: 150px;
	    color: #fff;
	    padding: 10px 0 0 15px;
	    line-height: 1.1;
	    font-size: 2em;
	    font-style: italic;
	    font-family: 'Roboto';
	    font-weight: 300;
	    color: #fff;
	    text-shadow: 2px 2px 2px rgba(0, 0, 0, 0.8);
	}
	.h2-div{
		max-width: 1100px;
		display: flex;
		justify-content: flex-start;
		align-items: center;
		margin: 80px auto 80px auto;
	}
</style>
<body>
<div class="h2-div">
	<h2 class="tit">전체영화</h2>
</div>
<div class="content-container">
	<div class="poster-div">
		<img src="../image/poster1.jpeg" alt="Poster 1" class="poster" width="245" height="325">
		<div class="rank">1</div><br>
		<a class="btn btn-primary" href="#123" role="button">예매</a>
	</div>
	<div class="poster-div">
		<img src="../image/poster2.jpg" alt="Poster 2" class="poster" width="245" height="325">
		<div class="rank">2</div><br>
		<a class="btn btn-primary" href="#" role="button">예매</a>
	</div>
	<div class="poster-div">
		<img src="../image/poster3.jpg" alt="Poster 3" class="poster" width="245" height="325">
		<div class="rank">3</div><br>
		<a class="btn btn-primary" href="#" role="button">예매</a>
	</div>
	<div class="poster-div">
		<img src="../image/poster4.jpeg" alt="Poster 4" class="poster" width="245" height="325">
		<div class="rank">4</div><br>
		<a class="btn btn-primary" href="#" role="button">예매</a>
	</div>
</div>
</body>
</html>