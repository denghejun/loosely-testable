###使用Autofac + Moq使程序变得松耦合和可测试
###插件系统的设计
###想让程序能够发现自定义插件目录，可按如下配置：
```
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <probing privatePath=".\;.\plugins" />
    </assemblyBinding>
  </runtime>
```
  说明：.\:标识当前运行目录（如bin\Debug\）; .\plugins:标识自定义插件目录（如bin\Debug\plugins）