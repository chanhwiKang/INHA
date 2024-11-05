<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<!-- forward 액션 태그 실행 시, request와 response 객체가 같이 넘어감 -->
<!-- request 기본 객체의 속성을 이용한 값 전달 -->
<%
	request.setAttribute("id", "admin");
	request.setAttribute("pw", "adminpw");
	request.setAttribute("name", "hong");
%>

<jsp:forward page="getAttribute.jsp"/>

</body>
</html>