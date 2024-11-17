package week12;

import java.io.FileInputStream;
import java.io.IOException;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Properties;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletConfig;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebInitParam;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


/**
 * Servlet implementation class ControllerServlet
 */
@WebServlet(urlPatterns = "*.do",
initParams = {@WebInitParam(name = "initParam", 
							value = "/WEB-INF/commandHandler.properties")})
public class ControllerServlet extends HttpServlet {
	// Controller 기능
	private static final long serialVersionUID = 1L;
	
	// <커맨드, 핸드러인스턴스객체> 매핑 정보 저장
	private Map<String, CommandHandler> icmdHandlerMap = new HashMap<>();
	
	// 서블릿을 생성하고 초기화할 때 제일 먼저 실행되는 init() 메소드를 이용
	public void init(ServletConfig config) throws ServletException {
		String configFile = config.getInitParameter("initParam");
		Properties prop = new Properties();
		String configFilePath = config.getServletContext().getRealPath(configFile);
	
		try (FileInputStream fis = new FileInputStream(configFilePath)){
			prop.load(fis);
		} catch (Exception e) {
			throw new ServletException(e);
		}
		
		// 속성 파일을 하나씩 읽어서 키(요청패턴)와 실행명령 핸들러객체명을 먑애 저장
		Iterator<Object> keyIter = prop.keySet().iterator();
		while(keyIter.hasNext()) {
			String command = keyIter.next().toString();
			String handlerClassName = prop.getProperty(command);
			
			// 문자열 형식은 클래스를 객체 인스턴스로 변환
			try {
				Class<?> handlerClass = Class.forName(handlerClassName);
				CommandHandler handlerInstance = (CommandHandler) handlerClass.newInstance();
			
				// 최종 map에 저장
				icmdHandlerMap.put(command, handlerInstance);
			} catch (Exception e) {
				throw new ServletException();
			}
		}
	}
	
    /**
     * Default constructor. 
     */
    public ControllerServlet() {
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		try {
			process(request, response);
		} catch (ClassNotFoundException | ServletException | IOException | SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}


	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		try {
			process(request, response);
		} catch (ClassNotFoundException | ServletException | IOException | SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	private void process(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException, ClassNotFoundException, SQLException {
		// 클라이언트에서 요청이 들어오면 호출되는 메소드
		// 요청 RI를 체크해서 처리
		// getRequestURI -> /week11/hello.do
		String command = request.getRequestURI();
		
		// contextPath = /week11 
		command = command.substring(request.getContextPath().length()+1);
		// command = hello.do
		
		// command를 키로 해당 핸들러 객체를 가져온다.
		CommandHandler handler = icmdHandlerMap.get(command);
		
		String viewPage = handler.process(request, response);
		
		
		// 컨트롤러에서 다음 페이지로 전달하는 방법
		RequestDispatcher rd = request.getRequestDispatcher("/WEB-INF/views/"+viewPage+".jsp");
		rd.forward(request, response);
	}
}
