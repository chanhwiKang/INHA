<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
이 페이지는 getAttribute.jsp가 생성한 것
<%
	String id = (String)request.getAttribute("id");
	String pw = (String)request.getAttribute("pw");
	String name = (String)request.getAttribute("name");
%>
<h3>request 기본객체의 속성을 이용한 값 던잘 결과</h3>
id : <%= id %><br>
	pw : <%= pw %><br>
	name : <%= name %>
</body>
</html>