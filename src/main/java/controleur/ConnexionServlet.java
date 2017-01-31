package controleur;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class ConnexionServlet
 */
@WebServlet( name="Connexion", urlPatterns = "/ConnexionServlet" )
public class ConnexionServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	 private String paramLogin;
	    private String paramPassword;
	     
	    public void init() throws ServletException {
	        this.paramLogin = "";
	        this.paramPassword = "";
	        }
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ConnexionServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#service(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void service(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		 String login = request.getParameter("login");
	        String pwd = request.getParameter("pwd");
	         
	        request.setAttribute("login", login);
	        request.setAttribute("pwd", pwd);
	        
	        
	        /*if(this.paramLogin.equalsIgnoreCase(login) && this.paramPassword.equalsIgnoreCase(pwd)){
	            dispatcher = request.getRequestDispatcher("/Accueil.jsp");
	        }else{
	            dispatcher = request.getRequestDispatcher("/connexion.jsp");
	        }
	        dispatcher.forward(request, response);
	     */
	        request.getRequestDispatcher("vue/Accueil.jsp").forward(request, response);	        
	}
	

	

}
