using System; 

class URI {

      static void Main(string[] args) {
        int i = 0;
        string entrada = "";
        int[] total = new int[3];
        
        entrada = "";
       
        for(i=0;i<=2;i++){
            total[i] = 0;
            entrada = "";
            
           logicaDoCawCaw(entrada, total, i);
            
        } 
        for(i=0;i<=2;i++)
        {
            Console.Write("{0}\n",total[i]);
        }    
    }    

    public static void logicaDoCawCaw(string entrada, int[] total, int i) {
        while (entrada != "caw caw"){
                
                entrada = Console.ReadLine();
                
                if(entrada == "caw caw")
                {
                    break;
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
                else if(entrada == "***")
                {
                    total[i] += 7;
                }
            
            }
    }
}