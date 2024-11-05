<%@page import="week2.MemberInfo"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	MemberInfo member = new MemberInfo();
%>
<c:set var="m" value="<%=member %>" scope="request"/>
<c:set property="id" target="${m }" value="admin"/>
<c:set property="password" target="${m }" value="adminPassword"/>
<c:set property="name" target="${m }" value="hong"/>
<%-- <jsp:forward page="jstlResult2.jsp"/> --%>
<jsp:forward page="choose.jsp"/>
</body>
</html>