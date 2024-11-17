package week12;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class QueryEmpHandler implements CommandHandler{

	@Override
	public String process(HttpServletRequest request, HttpServletResponse response) throws ClassNotFoundException, SQLException {
		// 사원목록 요청이 들어왔을 때 처리되는 부분
		
		// db 연결
		String jdbcDriver = "com.mysql.cj.jdbc.Driver";
		String jdbcURL = "jdbc:mysql://localhost:3306/jspdb_c";
		String dbUser = "root";
		String dbPass = "cksgnl!2";
		
		Class.forName(jdbcDriver);
		Connection conn = DriverManager.getConnection(jdbcURL, dbUser, dbPass);
		
		String sql = "select * from emp";
		
		Statement stmt = conn.createStatement();
		ResultSet rs = stmt.executeQuery(sql);
		
		List<Emp> list = new ArrayList<>();
		while(rs.next()) {
			Emp emp = new Emp(
					rs.getString("empno"),
					rs.getString("empname"),
					rs.getString("empdept"),
					rs.getString("empjob"),
					rs.getInt("empsal")
				);
			list.add(emp);
		}
		request.setAttribute("list", list);
		return "queryEmp_list";
	}

}
