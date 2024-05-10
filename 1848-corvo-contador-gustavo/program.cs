using System; 

class URI {

      static void Main(string[] args) {
        int i = 0;
        int[] total = new int[3];
        
        string entrada = "";
       
        for(i=0;i<=2;i++){
            total[i] = 0;
            entrada = "";
            
            while (entrada != "caw caw"){
                
                entrada = Console.ReadLine();
                
                if(entrada == "caw caw")
                {
                    break;
                } 
                else if(entrada == "--*")
                {
                    total[i] += 1;
                }
                else if(entrada == "-*-")
                {
                    total[i] += 2;
                }
                else if(entrada == "-**")
                {
                    total[i] += 3;
                }
                else if(entrada == "*--")
                {
                    total[i] += 4;
                }
                else if(entrada == "*-*")
                {
                    total[i] += 5;
                }
                else if(entrada == "**-")
                {
                    total[i] += 6;
                }
                else if(entrada == "***")
                {
                    total[i] += 7;
                }
            
            }
            
        } 
        for(i=0;i<=2;i++)
        {
            Console.WriteLine("{0}",total[i]);
        }    
    }    
}