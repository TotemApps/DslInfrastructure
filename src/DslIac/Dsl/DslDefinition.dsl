<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="9ac27611-e568-4e3b-a9e3-d6734baf1af7" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacLanguage" Name="IacLanguage" DisplayName="IacLanguage" Namespace="Variamos.IacTemplateGenerator.IacLanguage" ProductName="IacTemplateGenerator" CompanyName="Variamos" PackageGuid="129e39c0-9f0c-4a4d-8617-67ee17a6211b" PackageNamespace="Variamos.IacTemplateGenerator.IacLanguage" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="f9375a29-ff04-4f61-926f-50894315f0d6" Description="The root in which all other elements are embedded. Appears as a diagram." Name="IacModel" DisplayName="Iac Model" Namespace="Variamos.IacTemplateGenerator.IacLanguage">
      <Properties>
        <DomainProperty Id="83d8ef07-00ab-4f81-8faf-bfca0d99f415" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacModel.Name" Name="name" DisplayName="Name" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="19122e18-f20f-4388-b42c-f797cf2083ab" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacModel.Cloud Provider" Name="cloudProvider" DisplayName="Cloud Provider">
          <Type>
            <DomainEnumerationMoniker Name="CloudProviderEnumerator" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="5acc08ff-48ba-4b65-b0ed-2f8569a0c3ca" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacModel.Resource Group" Name="resourceGroup" DisplayName="Resource Group">
          <Notes>Azure Resource Group</Notes>
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Vm" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>IacModelHasVms.Vms</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="NetworkInterface" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>IacModelHasNetworkInterfaced.NetworkInterfaced</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="e9b0540e-3619-4b9c-8b27-7c93df83f777" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.Vm" Name="Vm" DisplayName="Vm" Namespace="Variamos.IacTemplateGenerator.IacLanguage">
      <BaseClass>
        <DomainClassMoniker Name="AzureComponent" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="3330d97b-1e95-41bb-ac3a-878d26a73ed9" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.Vm.Vm Size" Name="vmSize" DisplayName="Vm Size">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="6a35f0a4-ca0d-445b-a566-c61f64501a61" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.AzureComponent" Name="AzureComponent" DisplayName="Azure Component" InheritanceModifier="Abstract" Namespace="Variamos.IacTemplateGenerator.IacLanguage">
      <Properties>
        <DomainProperty Id="5b20d601-5bf8-472d-8352-0835d7f7b31c" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.AzureComponent.Name" Name="name" DisplayName="Name" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="db650e2d-155f-430d-b574-e812e05d51f8" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.AzureComponent.Label" Name="label" DisplayName="Label">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="d798df07-bc61-4ccf-b9b8-43d54a829b36" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.NetworkInterface" Name="NetworkInterface" DisplayName="Network Interface" Namespace="Variamos.IacTemplateGenerator.IacLanguage">
      <BaseClass>
        <DomainClassMoniker Name="AzureComponent" />
      </BaseClass>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="f8e23beb-7130-4b8b-bccc-fd99d7a1b483" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacModelHasVms" Name="IacModelHasVms" DisplayName="Iac Model Has Vms" Namespace="Variamos.IacTemplateGenerator.IacLanguage" IsEmbedding="true">
      <Source>
        <DomainRole Id="1366c89a-0345-44bb-8ad5-c5ba5ee381d5" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacModelHasVms.IacModel" Name="IacModel" DisplayName="Iac Model" PropertyName="Vms" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Vms">
          <RolePlayer>
            <DomainClassMoniker Name="IacModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="ee01621b-4fc7-4f3d-95ce-924112256626" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacModelHasVms.Vm" Name="Vm" DisplayName="Vm" PropertyName="IacModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Iac Model">
          <RolePlayer>
            <DomainClassMoniker Name="Vm" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="ac2752f8-8ebd-4928-b5b3-8376ffce88bd" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacModelHasNetworkInterfaced" Name="IacModelHasNetworkInterfaced" DisplayName="Iac Model Has Network Interfaced" Namespace="Variamos.IacTemplateGenerator.IacLanguage" IsEmbedding="true">
      <Source>
        <DomainRole Id="dd3478e2-58eb-4d47-b8c4-fb1faf995ddd" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacModelHasNetworkInterfaced.IacModel" Name="IacModel" DisplayName="Iac Model" PropertyName="NetworkInterfaced" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Network Interfaced">
          <RolePlayer>
            <DomainClassMoniker Name="IacModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="03f18c53-f437-4724-a3d6-2e38d00c4a1b" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacModelHasNetworkInterfaced.NetworkInterface" Name="NetworkInterface" DisplayName="Network Interface" PropertyName="IacModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Iac Model">
          <RolePlayer>
            <DomainClassMoniker Name="NetworkInterface" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="08568fe9-0f1b-4448-9b2a-59ce80a30fe2" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.VmReferencesNetworkInterfaced" Name="VmReferencesNetworkInterfaced" DisplayName="Vm References Network Interfaced" Namespace="Variamos.IacTemplateGenerator.IacLanguage">
      <Source>
        <DomainRole Id="8a3ed4d2-1007-48c2-83a5-5d0082f17fe1" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.VmReferencesNetworkInterfaced.Vm" Name="Vm" DisplayName="Vm" PropertyName="NetworkInterfaced" PropertyDisplayName="Network Interfaced">
          <RolePlayer>
            <DomainClassMoniker Name="Vm" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="5fb7384e-3f3c-49f1-8106-89a485b0a9b3" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.VmReferencesNetworkInterfaced.NetworkInterface" Name="NetworkInterface" DisplayName="Network Interface" PropertyName="Vms" PropertyDisplayName="Vms">
          <RolePlayer>
            <DomainClassMoniker Name="NetworkInterface" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
    <DomainEnumeration Name="CloudProviderEnumerator" Namespace="Variamos.IacTemplateGenerator.IacLanguage" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator">
      <Literals>
        <EnumerationLiteral Description="Description for Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator.Azure" Name="Azure" Value="0" />
        <EnumerationLiteral Description="Description for Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator.AWS" Name="AWS" Value="1" />
        <EnumerationLiteral Description="Description for Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator.gpc" Name="gpc" Value="2" />
      </Literals>
    </DomainEnumeration>
  </Types>
  <Shapes>
    <ImageShape Id="3c40cb08-f0bb-4e4a-9234-1360069c4d91" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.VmShape" Name="VmShape" DisplayName="Vm Shape" Namespace="Variamos.IacTemplateGenerator.IacLanguage" FixedTooltipText="Vm Shape" InitialWidth="1" InitialHeight="1" Image="Resources\virtualMachinesShape.png">
      <ShapeHasDecorators Position="OuterBottomCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Label" DisplayName="Label" DefaultText="Label" />
      </ShapeHasDecorators>
    </ImageShape>
    <ImageShape Id="abcf12ea-1b89-4be6-b8e6-6b2c9b3ddeff" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.NetworkInterfaceShape" Name="NetworkInterfaceShape" DisplayName="Network Interface Shape" Namespace="Variamos.IacTemplateGenerator.IacLanguage" FixedTooltipText="Network Interface Shape" InitialWidth="1" InitialHeight="1" Image="Resources\networkInterfacesShape.png">
      <ShapeHasDecorators Position="OuterBottomCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Label" DisplayName="Label" DefaultText="Label" />
      </ShapeHasDecorators>
    </ImageShape>
  </Shapes>
  <Connectors>
    <Connector Id="ad4cd0b1-a345-4596-9ff0-49fb73078779" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.VmNetworkInterfaceConnector" Name="VmNetworkInterfaceConnector" DisplayName="Vm Network Interface Connector" Namespace="Variamos.IacTemplateGenerator.IacLanguage" FixedTooltipText="Vm Network Interface Connector" RoutingStyle="Straight" />
  </Connectors>
  <XmlSerializationBehavior Name="IacLanguageSerializationBehavior" Namespace="Variamos.IacTemplateGenerator.IacLanguage">
    <ClassData>
      <XmlClassData TypeName="IacModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="iacModelMoniker" ElementName="iacModel" MonikerTypeName="IacModelMoniker">
        <DomainClassMoniker Name="IacModel" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="IacModel/name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="cloudProvider">
            <DomainPropertyMoniker Name="IacModel/cloudProvider" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="resourceGroup">
            <DomainPropertyMoniker Name="IacModel/resourceGroup" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="vms">
            <DomainRelationshipMoniker Name="IacModelHasVms" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="networkInterfaced">
            <DomainRelationshipMoniker Name="IacModelHasNetworkInterfaced" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="IacLanguageDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="iacLanguageDiagramMoniker" ElementName="iacLanguageDiagram" MonikerTypeName="IacLanguageDiagramMoniker">
        <DiagramMoniker Name="IacLanguageDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="Vm" MonikerAttributeName="" SerializeId="true" MonikerElementName="vmMoniker" ElementName="vm" MonikerTypeName="VmMoniker">
        <DomainClassMoniker Name="Vm" />
        <ElementData>
          <XmlPropertyData XmlName="vmSize">
            <DomainPropertyMoniker Name="Vm/vmSize" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="networkInterfaced">
            <DomainRelationshipMoniker Name="VmReferencesNetworkInterfaced" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="IacModelHasVms" MonikerAttributeName="" SerializeId="true" MonikerElementName="iacModelHasVmsMoniker" ElementName="iacModelHasVms" MonikerTypeName="IacModelHasVmsMoniker">
        <DomainRelationshipMoniker Name="IacModelHasVms" />
      </XmlClassData>
      <XmlClassData TypeName="VmShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="vmShapeMoniker" ElementName="vmShape" MonikerTypeName="VmShapeMoniker">
        <ImageShapeMoniker Name="VmShape" />
      </XmlClassData>
      <XmlClassData TypeName="AzureComponent" MonikerAttributeName="" SerializeId="true" MonikerElementName="azureComponentMoniker" ElementName="azureComponent" MonikerTypeName="AzureComponentMoniker">
        <DomainClassMoniker Name="AzureComponent" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="AzureComponent/name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="label">
            <DomainPropertyMoniker Name="AzureComponent/label" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="NetworkInterface" MonikerAttributeName="" SerializeId="true" MonikerElementName="networkInterfaceMoniker" ElementName="networkInterface" MonikerTypeName="NetworkInterfaceMoniker">
        <DomainClassMoniker Name="NetworkInterface" />
      </XmlClassData>
      <XmlClassData TypeName="IacModelHasNetworkInterfaced" MonikerAttributeName="" SerializeId="true" MonikerElementName="iacModelHasNetworkInterfacedMoniker" ElementName="iacModelHasNetworkInterfaced" MonikerTypeName="IacModelHasNetworkInterfacedMoniker">
        <DomainRelationshipMoniker Name="IacModelHasNetworkInterfaced" />
      </XmlClassData>
      <XmlClassData TypeName="NetworkInterfaceShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="networkInterfaceShapeMoniker" ElementName="networkInterfaceShape" MonikerTypeName="NetworkInterfaceShapeMoniker">
        <ImageShapeMoniker Name="NetworkInterfaceShape" />
      </XmlClassData>
      <XmlClassData TypeName="VmReferencesNetworkInterfaced" MonikerAttributeName="" SerializeId="true" MonikerElementName="vmReferencesNetworkInterfacedMoniker" ElementName="vmReferencesNetworkInterfaced" MonikerTypeName="VmReferencesNetworkInterfacedMoniker">
        <DomainRelationshipMoniker Name="VmReferencesNetworkInterfaced" />
      </XmlClassData>
      <XmlClassData TypeName="VmNetworkInterfaceConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="vmNetworkInterfaceConnectorMoniker" ElementName="vmNetworkInterfaceConnector" MonikerTypeName="VmNetworkInterfaceConnectorMoniker">
        <ConnectorMoniker Name="VmNetworkInterfaceConnector" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="IacLanguageExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="VmReferencesNetworkInterfacedBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="VmReferencesNetworkInterfaced" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Vm" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="NetworkInterface" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="ad1f4720-ac7c-4700-a17c-52efa3d6b906" Description="Description for Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDiagram" Name="IacLanguageDiagram" DisplayName="Minimal Language Diagram" Namespace="Variamos.IacTemplateGenerator.IacLanguage">
    <Class>
      <DomainClassMoniker Name="IacModel" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Vm" />
        <ParentElementPath>
          <DomainPath>IacModelHasVms.IacModel/!IacModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="VmShape/Label" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="AzureComponent/label" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <ImageShapeMoniker Name="VmShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="NetworkInterface" />
        <ParentElementPath>
          <DomainPath>IacModelHasNetworkInterfaced.IacModel/!IacModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="NetworkInterfaceShape/Label" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="AzureComponent/label" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <ImageShapeMoniker Name="NetworkInterfaceShape" />
      </ShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="VmNetworkInterfaceConnector" />
        <DomainRelationshipMoniker Name="VmReferencesNetworkInterfaced" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="variamosiacmodel" EditorGuid="4f2140a6-6437-47ea-a5a0-94f059ff9f2d">
    <RootClass>
      <DomainClassMoniker Name="IacModel" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="IacLanguageSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="IacLanguage">
      <ElementTool Name="VmsTool" ToolboxIcon="Resources\virtualMachinesIcon.bmp" Caption="VmsTool" Tooltip="Vms Tool" HelpKeyword="VmsTool">
        <DomainClassMoniker Name="Vm" />
      </ElementTool>
      <ElementTool Name="NetworkIterfaceTool" ToolboxIcon="Resources\networkInterfacesIcon.bmp" Caption="NetworkIterfaceTool" Tooltip="Network Iterface Tool" HelpKeyword="NetworkIterfaceTool">
        <DomainClassMoniker Name="NetworkInterface" />
      </ElementTool>
      <ConnectionTool Name="VmNetworkInterfaceTool" ToolboxIcon="Resources\ExampleConnectorToolBitmap.bmp" Caption="VmNetworkInterfaceTool" Tooltip="Vm Network Interface Tool" HelpKeyword="VmNetworkInterfaceTool">
        <ConnectionBuilderMoniker Name="IacLanguage/VmReferencesNetworkInterfacedBuilder" />
      </ConnectionTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="IacLanguageDiagram" />
  </Designer>
  <Explorer ExplorerGuid="87d95db3-b7fb-467f-8fe3-e71005870d08" Title="IacLanguage Explorer">
    <ExplorerBehaviorMoniker Name="IacLanguage/IacLanguageExplorer" />
  </Explorer>
</Dsl>