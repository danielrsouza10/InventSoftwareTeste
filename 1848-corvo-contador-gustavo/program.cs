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
                      total[i]++;
                }
                else if(entrada == "***")
                {
                    total[i] += 7;
                }
            
            }
    }
}
