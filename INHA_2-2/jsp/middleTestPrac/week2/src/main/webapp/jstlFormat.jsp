<%@page import="week2.MemberInfo"%>
<%@page import="java.util.Date"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	MemberInfo member = new MemberInfo();
	request.setAttribute("mem", member);
%>
<c:set var="date" value="<%= new Date() %>"/>
	오늘 날짜 <fmt:formatDate value="${date }"/><br>
	현재 시작 <fmt:formatDate value="${date }" type="time"/>
	오늘 날짜 <fmt:formatDate value="${date }" type="date" pattern="yyyy/MM/dd(E)"/><br>
	현재 시각 <fmt:formatDate value="${date }" type="time" pattern="(a)hh:mm:ss"/><hr>
	
	금액: <fmt:formatNumber value="10000000" type="currency" currencySymbol="$"/><br>
	퍼센트 <fmt:formatNumber value="0.95" type="percent"/><hr>
	
	<c:set var="m" value="${mem }" scope="request"/>
	<c:set target="${m }" property="name" value="홍"/>
	<c:set var="arr" value="<%=new int[] {0,1,2,3,4,5} %>" scope="request"/>
	<c:forEach var="a" items="${arr }" begin="2" end="4" step="2" varStatus="status">
		${a },${status.index }, ${varStatus.count }<br>
	</c:forEach>
	
</body>
</html>