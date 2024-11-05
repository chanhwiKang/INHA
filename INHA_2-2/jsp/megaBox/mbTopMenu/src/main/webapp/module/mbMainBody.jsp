<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<style>
	body{
		background: url("https://img.megabox.co.kr/SharedImg/2024/10/21/6K1gyRHKZ96WTr3tsLFgAzN9nxV47Ft3_380.jpg") no-repeat;
		background-size: 100%;
		
	}
	#body-div{
		background-color: rgba(0,0,0,0.8);
		overflow: hidden;
		width: 100%;
	
		height: 100vh; /* 뷰포트의 전체 높이 사용 */
    }
	.btn-primary{
		width: 245px;
		background: #037b94;
	}
	.d-flex {
	    display: flex !important;
	    align-items: center;
	}
	.search-btn{
		padding-left: 0px;
	}
	.btn-container {
		max-width: 1100px;
		display: flex;
		justify-content: center;
		margin: 0 auto; /* 중앙 정렬을 위한 마진 */
		margin-top: 50px;
		
		color: #000;
    	border-bottom: 2px solid rgba(255, 255, 255, 0.2);
	}
	.aTag-container {
		color: #aaa;
		font-size: 15px;
		max-width: 1100px;
		display: flex;
		justify-content: flex-end;
		margin: 0 auto; /* 중앙 정렬을 위한 마진 */
	}
	.more-movie {
	    color: inherit; /* 부모 요소의 색상을 따르게 설정 */
	    text-decoration: none; /* 밑줄 제거 */
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
	.navbar{
		max-width: 1100px;
		display: flex;
		justify-content: center;
		align-items: center;
		gap: 30px;
	    background-color: rgba(0,0,0, 0.2) !important;
	    border-radius: 8px;
	}
	.navbar-expand-lg .navbar-collapse {
        display: flex !important;
        flex-basis: auto;
        justify-content: center;
        align-items: center;
    }
    .form-control{
    	width: 170px;
    	height: 40px;
    }
    .navbar-nav{
    	display: flex;
        justify-content: center;
        align-items: center;
    	flex: 1;
    	gap: 150px;
    }
    .nav-div .nav-link{
    	width: 210px;
	    font-weight: 400;
	    font-size: 15px;
	    font-family: NanumBarunGothic, Dotum, '돋움', sans-serif;
	    color: white !important;
	    text-align: center;
    }
</style>

<body><div id="body-div">
<!-- mbMainBody.jsp -->
<div class="btn-container">
	<a style="color: white">박스오피스</a>
</div>
<div class="aTag-container">
	<a href="#" class="more-movie" title="더 많은 영화보기">더 많은 영화보기</a>
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

<nav class="navbar navbar-expand-lg bg-body-tertiary" style="margin: 80px auto auto;">
	<div class="container-fluid">
		<div class="collapse navbar-collapse" id="navbarNavAltMarkup">
			<div class="navbar-nav">
				<div class="nav-div">
					<form class="d-flex" role="search">
						<input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
						<button type="button" class="btn search-btn" id="btnSearch">
							<img src="../image/ico-search-white.png"></button>
					</form>
				</div>
				<div class="nav-div">
					<a class="nav-link" href="mbAllMoviePage.jsp">박스오피스</a>
				</div><div class="nav-div">
					<a class="nav-link" href="#">예매</a>
				</div>
			</div>
		</div>
	</div>
</nav>
</div>
</body>
</html>