<%@page import="java.util.Map"%>
<%@page import="java.util.Enumeration"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h2>요청 파라미터 출력 </h2>
<h3>requet.getParameter() method 사용</h3>
name Param = <%= request.getParameter("name") %><br>
addr Param = <%= request.getParameter("addr") %><br>
<hr>
<h3>request.getParameterValues() method 사용</h3>
<%
	String[] values = request.getParameterValues("pet");
if (values != null){
	for(int i=0; i<values.length; i++){
		out.println(values[i]);
	}
}
%>
<br>
<hr>
<h3>request.getParameterNames() method 사용</h3>
<%
	Enumeration paramEnum = request.getParameterNames();
	while(paramEnum.hasMoreElements()){
		String name = (String)paramEnum.nextElement();
		out.println(name);
	}
%>
<hr>
<h3>request.getParameterMap() method 사용</h3>
<%
	// (parameter name, value)의 쌍으로 저장
	Map paramMap = request.getParameterMap();
	String[] nameParam = (String[])paramMap.get("pet");
	if(nameParam != null){
		out.println(nameParam[0]);
	}
%>





</body>
</html>