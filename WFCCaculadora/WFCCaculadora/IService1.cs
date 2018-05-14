using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFCCaculadora
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Suma(int num1, int num2);
        [OperationContract]
        int Resta(int num1, int num2);
        [OperationContract]
        int Division(int num1, int num2);
        [OperationContract]
        int Multiplicacion(int num1, int num2);

        // TODO: agregue aquí sus operaciones de servicio
    }
    //[DataContrac] sirve para wcf serialice los objetos que nostros le pasemos
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "WFCCaculadora.ContractType".
   
}
