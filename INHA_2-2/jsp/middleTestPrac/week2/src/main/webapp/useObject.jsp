<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<jsp:useBean id="member" class="week2.MemberInfo" scope="request"/>
name: <jsp:getProperty name="member" property="name"/>
id: <jsp:getProperty name="member" property="id"/>
email: <jsp:getProperty name="member" property="email"/>
</body>
</html>