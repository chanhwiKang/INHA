<%@page import="java.util.Date"%>
<%@page import="java.text.SimpleDateFormat"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	request.setCharacterEncoding("utf-8");
	SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
	Date date = new Date();
	String strDate = sdf.format(date);
%>
<jsp:useBean id="member" class="week5.MemberInfo" />
<jsp:setProperty property="*" name="member"/>
<jsp:setProperty property="password" name="member" value="<%=member.getId() %>"/>
<jsp:setProperty property="registerDate" name="member" value="<%= strDate%>"/>

<h1> 회원 가입 결과</h1>
<table border="1" cellpadding="3">
	<tr>
		<td>id</td>
		<td><jsp:getProperty property="id" name="member"/></td>
	</tr>
	<tr>
		<td>pw</td>
		<td><jsp:getProperty property="password" name="member"/></td>
	</tr>
	<tr>
		<td>name</td>
		<td><jsp:getProperty property="name" name="member"/></td>
	</tr>
	<tr>
		<td>email</td>
		<td><jsp:getProperty property="email" name="member"/></td>
	</tr>
	<tr>
		<td>regDate</td>
		<td><jsp:getProperty property="registerDate" name="member"/></td>
	</tr>
</table>
</body>
</html>