<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="Azure" generation="1" functional="0" release="0" Id="cce443d6-c724-4282-9550-3b307e593cf8" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="LoggerWorkerRole:InputRequest" protocol="tcp">
          <inToChannel>
            <lBChannelMoniker name="/Azure/AzureGroup/LB:LoggerWorkerRole:InputRequest" />
          </inToChannel>
        </inPort>
        <inPort name="ReaderWorkerRole:InputRequest" protocol="tcp">
          <inToChannel>
            <lBChannelMoniker name="/Azure/AzureGroup/LB:ReaderWorkerRole:InputRequest" />
          </inToChannel>
        </inPort>
        <inPort name="WebRole:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Azure/AzureGroup/LB:WebRole:Endpoint1" />
          </inToChannel>
        </inPort>
        <inPort name="WriterWorkerRole:InputRequest" protocol="tcp">
          <inToChannel>
            <lBChannelMoniker name="/Azure/AzureGroup/LB:WriterWorkerRole:InputRequest" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="LoggerWorkerRole:ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapLoggerWorkerRole:ConnectionString" />
          </maps>
        </aCS>
        <aCS name="LoggerWorkerRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapLoggerWorkerRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="LoggerWorkerRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapLoggerWorkerRoleInstances" />
          </maps>
        </aCS>
        <aCS name="ReaderWorkerRole:ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapReaderWorkerRole:ConnectionString" />
          </maps>
        </aCS>
        <aCS name="ReaderWorkerRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapReaderWorkerRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="ReaderWorkerRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapReaderWorkerRoleInstances" />
          </maps>
        </aCS>
        <aCS name="WebRole:ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapWebRole:ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapWebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WebRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapWebRoleInstances" />
          </maps>
        </aCS>
        <aCS name="WriterWorkerRole:ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapWriterWorkerRole:ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WriterWorkerRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapWriterWorkerRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WriterWorkerRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Azure/AzureGroup/MapWriterWorkerRoleInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:LoggerWorkerRole:InputRequest">
          <toPorts>
            <inPortMoniker name="/Azure/AzureGroup/LoggerWorkerRole/InputRequest" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:ReaderWorkerRole:InputRequest">
          <toPorts>
            <inPortMoniker name="/Azure/AzureGroup/ReaderWorkerRole/InputRequest" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:WebRole:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Azure/AzureGroup/WebRole/Endpoint1" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:WriterWorkerRole:InputRequest">
          <toPorts>
            <inPortMoniker name="/Azure/AzureGroup/WriterWorkerRole/InputRequest" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapLoggerWorkerRole:ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Azure/AzureGroup/LoggerWorkerRole/ConnectionString" />
          </setting>
        </map>
        <map name="MapLoggerWorkerRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Azure/AzureGroup/LoggerWorkerRole/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapLoggerWorkerRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Azure/AzureGroup/LoggerWorkerRoleInstances" />
          </setting>
        </map>
        <map name="MapReaderWorkerRole:ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Azure/AzureGroup/ReaderWorkerRole/ConnectionString" />
          </setting>
        </map>
        <map name="MapReaderWorkerRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Azure/AzureGroup/ReaderWorkerRole/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapReaderWorkerRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Azure/AzureGroup/ReaderWorkerRoleInstances" />
          </setting>
        </map>
        <map name="MapWebRole:ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Azure/AzureGroup/WebRole/ConnectionString" />
          </setting>
        </map>
        <map name="MapWebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Azure/AzureGroup/WebRole/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWebRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Azure/AzureGroup/WebRoleInstances" />
          </setting>
        </map>
        <map name="MapWriterWorkerRole:ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Azure/AzureGroup/WriterWorkerRole/ConnectionString" />
          </setting>
        </map>
        <map name="MapWriterWorkerRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Azure/AzureGroup/WriterWorkerRole/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWriterWorkerRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Azure/AzureGroup/WriterWorkerRoleInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="LoggerWorkerRole" generation="1" functional="0" release="0" software="C:\Users\Lenovo\source\repos\Azure\Azure\csx\Debug\roles\LoggerWorkerRole" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaWorkerHost.exe " memIndex="-1" hostingEnvironment="consoleroleadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="InputRequest" protocol="tcp" portRanges="10102" />
            </componentports>
            <settings>
              <aCS name="ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;LoggerWorkerRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;LoggerWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;ReaderWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WebRole&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WriterWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Azure/AzureGroup/LoggerWorkerRoleInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Azure/AzureGroup/LoggerWorkerRoleUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Azure/AzureGroup/LoggerWorkerRoleFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
        <groupHascomponents>
          <role name="ReaderWorkerRole" generation="1" functional="0" release="0" software="C:\Users\Lenovo\source\repos\Azure\Azure\csx\Debug\roles\ReaderWorkerRole" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaWorkerHost.exe " memIndex="-1" hostingEnvironment="consoleroleadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="InputRequest" protocol="tcp" portRanges="10101" />
            </componentports>
            <settings>
              <aCS name="ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;ReaderWorkerRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;LoggerWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;ReaderWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WebRole&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WriterWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Azure/AzureGroup/ReaderWorkerRoleInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Azure/AzureGroup/ReaderWorkerRoleUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Azure/AzureGroup/ReaderWorkerRoleFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
        <groupHascomponents>
          <role name="WebRole" generation="1" functional="0" release="0" software="C:\Users\Lenovo\source\repos\Azure\Azure\csx\Debug\roles\WebRole" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;WebRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;LoggerWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;ReaderWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WebRole&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WriterWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Azure/AzureGroup/WebRoleInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Azure/AzureGroup/WebRoleUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Azure/AzureGroup/WebRoleFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
        <groupHascomponents>
          <role name="WriterWorkerRole" generation="1" functional="0" release="0" software="C:\Users\Lenovo\source\repos\Azure\Azure\csx\Debug\roles\WriterWorkerRole" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaWorkerHost.exe " memIndex="-1" hostingEnvironment="consoleroleadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="InputRequest" protocol="tcp" portRanges="10100" />
            </componentports>
            <settings>
              <aCS name="ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;WriterWorkerRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;LoggerWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;ReaderWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WebRole&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WriterWorkerRole&quot;&gt;&lt;e name=&quot;InputRequest&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Azure/AzureGroup/WriterWorkerRoleInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Azure/AzureGroup/WriterWorkerRoleUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Azure/AzureGroup/WriterWorkerRoleFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="WebRoleUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyUpdateDomain name="WriterWorkerRoleUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyUpdateDomain name="ReaderWorkerRoleUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyUpdateDomain name="LoggerWorkerRoleUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="LoggerWorkerRoleFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyFaultDomain name="ReaderWorkerRoleFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyFaultDomain name="WebRoleFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyFaultDomain name="WriterWorkerRoleFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="LoggerWorkerRoleInstances" defaultPolicy="[1,1,1]" />
        <sCSPolicyID name="ReaderWorkerRoleInstances" defaultPolicy="[1,1,1]" />
        <sCSPolicyID name="WebRoleInstances" defaultPolicy="[1,1,1]" />
        <sCSPolicyID name="WriterWorkerRoleInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="35776c1b-5110-427e-8802-3f1ae1ff5661" ref="Microsoft.RedDog.Contract\ServiceContract\AzureContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="e6fd4394-c59c-406c-a0e9-8541756ea65f" ref="Microsoft.RedDog.Contract\Interface\LoggerWorkerRole:InputRequest@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Azure/AzureGroup/LoggerWorkerRole:InputRequest" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="ed36512b-76ee-420c-baaa-179b6251f1a1" ref="Microsoft.RedDog.Contract\Interface\ReaderWorkerRole:InputRequest@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Azure/AzureGroup/ReaderWorkerRole:InputRequest" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="756a63b1-08b4-45ae-a635-76edb542a1ce" ref="Microsoft.RedDog.Contract\Interface\WebRole:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Azure/AzureGroup/WebRole:Endpoint1" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="68a33878-27be-4ace-a6e9-200da5786738" ref="Microsoft.RedDog.Contract\Interface\WriterWorkerRole:InputRequest@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Azure/AzureGroup/WriterWorkerRole:InputRequest" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>