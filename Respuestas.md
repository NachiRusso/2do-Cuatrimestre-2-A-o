Preguntas
a. ¿Qué diferencia existe entre el código fuente y el IL?

b. ¿Qué información contienen los metadatos?

c. ¿Qué función cumple el runtime?

d. ¿Qué diferencia existe entre JIT y AOT?

e. ¿Qué es un assembly?

f. ¿Qué diferencia existe entre una DLL y un EXE en el contexto de .NET?

g. ¿Para qué sirve Reflection?

h. ¿Por qué AppDomain no debe utilizarse como mecanismo moderno para crear dominios aislados en .NET 8?

i. ¿Qué tecnología utilizaríamos actualmente para cargar y descargar assemblies dinámicamente?

j. ¿Qué función cumple NuGet?

k. ¿Qué diferencia hay entre una publicación framework-dependent (FDD) y self-contained (SCD)?

l. ¿Qué significan las siglas IL, JIT, AOT y GC?
	

	Respuestas
	a. El código fuente es el conjunto de instrucciones escritas en un lenguaje de programación que los desarrolladores crean y editan. Por otro lado, IL (Intermediate Language) es un lenguaje intermedio al que se compila el código fuente antes de ser ejecutado por el runtime. IL es independiente del lenguaje de programación y es ejecutado por el Common Language Runtime (CLR) en .NET.
	b. Los metadatos contienen información sobre los tipos definidos en un assembly, como clases, interfaces, métodos, propiedades y eventos. También incluyen información sobre referencias a otros assemblies, atributos personalizados y detalles de seguridad. Los metadatos permiten al runtime y a las herramientas de desarrollo comprender la estructura y el comportamiento del código.
	c. El runtime, específicamente el Common Language Runtime (CLR) en .NET, es responsable de ejecutar aplicaciones .NET. Proporciona servicios como la gestión de memoria, la recolección de basura (GC), la seguridad, la interoperabilidad con otros lenguajes y la ejecución de código IL mediante JIT o AOT.
	d. JIT (Just-In-Time) es un proceso en el que el código IL se compila a código nativo en tiempo de ejecución, justo antes de su ejecución. AOT (Ahead-Of-Time) es un proceso en el que el código IL se compila a código nativo antes de la ejecución, generalmente durante la fase de compilación del proyecto. La principal diferencia es que JIT compila el código en tiempo de ejecución, mientras que AOT lo hace antes de la ejecución.
	e. Un assembly es una unidad de despliegue y ejecución en .NET que contiene código compilado (IL), metadatos y recursos. Puede ser un archivo ejecutable (.exe) o una biblioteca de enlace dinámico (.dll). Los assemblies permiten la reutilización de código y la organización de aplicaciones en componentes modulares.
	f. La principal diferencia entre una DLL (Dynamic Link Library) y un EXE (Executable) en el contexto de .NET es su propósito y forma de ejecución. Un EXE es un archivo ejecutable que puede iniciarse directamente por el sistema operativo, mientras que una DLL es una biblioteca que contiene código y recursos que pueden ser utilizados por otros programas, pero no puede ejecutarse por sí misma. Las DLLs permiten la reutilización de código y la modularidad en las aplicaciones.
	g. Reflection es una característica de .NET que permite inspeccionar y manipular tipos, métodos, propiedades y otros elementos del código en tiempo de ejecución. Con Reflection, los desarrolladores pueden obtener información sobre los assemblies cargados, crear instancias de tipos dinámicamente, invocar métodos y acceder a atributos personalizados, lo que facilita la creación de aplicaciones más flexibles y dinámicas.
	h. AppDomain no debe utilizarse como mecanismo moderno para crear dominios aislados en .NET 8 porque ha sido reemplazado por tecnologías más modernas y eficientes, como AssemblyLoadContext. AppDomain tiene limitaciones en cuanto a la carga y descarga de assemblies, y su uso puede llevar a problemas de rendimiento y complejidad en la gestión de recursos. AssemblyLoadContext proporciona un enfoque más flexible y seguro para cargar y descargar assemblies dinámicamente.
	i. Actualmente, para cargar y descargar assemblies dinámicamente en .NET, se utiliza la clase AssemblyLoadContext. Esta clase permite crear contextos de carga personalizados para assemblies, lo que facilita la carga y descarga de código en tiempo de ejecución sin afectar a otros assemblies o al dominio de la aplicación principal.
	j. NuGet es un administrador de paquetes para .NET que facilita la distribución y gestión de bibliotecas y dependencias en proyectos. Permite a los desarrolladores buscar, instalar, actualizar y eliminar paquetes de manera sencilla, asegurando que las aplicaciones tengan acceso a las versiones correctas de las bibliotecas necesarias para su funcionamiento.
	k. La diferencia entre una publicación framework-dependent (FDD) y self-contained (SCD) radica en cómo se distribuyen las aplicaciones .NET. Una publicación FDD depende del runtime de .NET instalado en el sistema donde se ejecuta la aplicación, lo que significa que el usuario debe tener el runtime adecuado para ejecutar la aplicación. En cambio, una publicación SCD incluye el runtime de .NET junto con la aplicación, lo que permite que la aplicación se ejecute en cualquier sistema sin necesidad de tener el runtime previamente instalado.
	l. Las siglas significan lo siguiente: IL / CIL	Intermediate Language / Common Intermediate Language. JIT	Just-In-Time — compila IL a nativo durante la ejecución. Ahead-of-Time — compila a nativo antes de la ejecución. GC	Garbage Collector — recolector automático de memoria.
		