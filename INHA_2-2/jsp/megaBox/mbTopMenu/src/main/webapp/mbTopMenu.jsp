<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
<style>
	
 	header {
 		background-color: rgb(15, 15, 15);
		display: flex;
		justify-content: center;
		align-items: center;
	}
	.nav {
		display: flex;
		justify-content: center; 
		align-items: center;
		
		padding-bottom: 0;
	}
	.nav-item {
		display: flex;
		justify-content: center;
		align-items: center;
		flex: 1;  /* 각 nav-item이 동일한 너비를 가지게 함 */
		height: 100%; /* li 요소의 높이를 header 높이에 맞추기 */
	}
	.top-nav {
		margin-top: auto; /* 아래로 밀어내기 */
		font-size: 22px;
		font-weight: bold;
	}
	.logo-size {
		height: 70px;
		width: auto;
	}
	ul {
	
		width: 1200px;
		height: 88px; /* ul의 높이 설정 */
	}
</style>
<body>
<!-- mbTopMenu.jsp -->
<header style="width: 100%; height: 88px;">
	<ul class="nav nav-underline">
	  <li class="nav-item">
	    <a class="nav-link top-nav" href="#">영화</a>
	  </li>
	  <li class="nav-item">
	    <a class="nav-link top-nav" href="#">예매</a>
	  </li>
	  <li class="nav-item">
	    <a class="nav-link top-nav" href="#"><img src="image/testLogo.png" alt="Logo" class="logo-size"></a>
	  </li>
	  <li class="nav-item">
	    <a class="nav-link top-nav" href="#">로그인</a>
	  </li>
	  <li class="nav-item">
	    <a class="nav-link top-nav" href="#">회원가입</a>
	  </li>
</ul>
</header>
<hr style="width: 100%; border: 1px solid #000; margin: 0px 0;">
</body>
</html>